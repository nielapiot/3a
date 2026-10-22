using System;
using Avalonia.Controls;
using Avalonia.Threading;

namespace minutnik;

public partial class MainWindow : Window
{
    private readonly DispatcherTimer _timer;
    private int _remainingSeconds = 25 * 60;
    private int _completedCycles;
    private bool _isWorkPhase = true;
    private bool _isRunning;

    public MainWindow()
    {
        InitializeComponent();

        _timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        _timer.Tick += OnTimerTick;
        UpdateDisplay();
    }

    private void OnStartPauseClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (_isRunning)
        {
            _timer.Stop();
            _isRunning = false;
            StartPauseButton.Content = "Wznów";
        }
        else
        {
            _isRunning = true;
            _timer.Start();
            StartPauseButton.Content = "Pauza";
        }

        UpdateSettingsAvailability();
    }

    private void OnResetClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _timer.Stop();
        _isRunning = false;
        _isWorkPhase = true;
        _completedCycles = 0;
        _remainingSeconds = GetDurationSeconds(WorkDurationInput);
        StartPauseButton.Content = "Start";
        UpdateDisplay();
        UpdateSettingsAvailability();
    }

    private void OnTimerTick(object? sender, EventArgs e)
    {
        if (_remainingSeconds > 0)
        {
            _remainingSeconds--;
        }

        if (_remainingSeconds == 0)
        {
            if (_isWorkPhase)
            {
                _isWorkPhase = false;
                _remainingSeconds = GetDurationSeconds(BreakDurationInput);
            }
            else
            {
                _isWorkPhase = true;
                _completedCycles++;
                _remainingSeconds = GetDurationSeconds(WorkDurationInput);
            }
        }

        UpdateDisplay();
    }

    private static int GetDurationSeconds(NumericUpDown input)
    {
        var minutes = decimal.ToInt32(decimal.Truncate(input.Value ?? 1));
        return minutes * 60;
    }

    private void UpdateDisplay()
    {
        TimerText.Text = $"{_remainingSeconds / 60:00}:{_remainingSeconds % 60:00}";
        PhaseText.Text = _isWorkPhase ? "Czas pracy" : "Czas na przerwę";
        CycleCountText.Text = _completedCycles.ToString();
    }

    private void UpdateSettingsAvailability()
    {
        WorkDurationInput.IsEnabled = !_isRunning;
        BreakDurationInput.IsEnabled = !_isRunning;
    }
}