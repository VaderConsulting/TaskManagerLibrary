# TaskManagerLibrary

TaskManagerLibrary is a C# WinForms UserControl that starts long-running tasks and reports status via a combo box and progress bar. Hosts call `Start(Action)` and receive a task index plus `IProgress<string>` so background work can push status strings onto the UI. The control keeps an `ObservableCollection<Task>` of long-running, fair-scheduled tasks and shows a task-count picture, a progress bar (`pbrTask`), and a status combo (`cmbStatus`). A companion WinForms test app (`TaskManagerTest`) hosts the control; the 2018 tree is a work-in-progress with empty collection-changed handlers and an unwired `LongRunningTask` demo loop.

**Source last updated:** 2018-02-22 · **Language:** C# · **Target:** .NET Framework 4.7.1 · **Output:** WinForms UserControl library + WinForms exe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `TaskManagerLibrary` | C# | class library (.NET 4.7.1) | `TaskManager` UserControl: `Start(Action)` plus `IProgress<string>` status |
| `TaskManagerTest` | C# | WinForms exe (.NET 4.7.1) | Host form with the control and a stub long-running action |

## How to open

Open `TaskManagerLibrary.sln` in Visual Studio 2017 or later (solution format 12.00 / Visual Studio 15, targeting .NET Framework 4.7.1). Run the `TaskManagerTest` project to host the control.

## Attribution and provenance

Working copy from Dave Robinson's OneDrive Historical Dev folder `TaskManagerLibrary`. Assembly title/product `TaskManager` and `TaskManagerTest`, empty company, copyright 2018. Original Dave Robinson / VaderConsulting code (not a Windows Task Scheduler wrapper).

## License

MIT. Copyright (c) 2026 VaderConsulting, for Dave Robinson's code. See `LICENSE`.
