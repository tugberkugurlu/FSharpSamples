open System
open System.Windows
open System.Windows.Controls

//opening and closing parentheses makes the variable function
let loadWindow() =
    let resourceLocator = new Uri("/HelloWorldWPF;component/MainWindow.xaml", UriKind.Relative)
    let window = Application.LoadComponent(resourceLocator) :?> Window
    (window.FindName("clickButton") :?> Button).Click.Add(
        fun _ -> MessageBox.Show("Hello Wold!") |> ignore)

    //we would like to return this newly loaded window
    //we need a return value.
    //in f#, the last value that is evaluated within a particular function declaration
    //will be the return value of the function itself
    window

[<STAThread>]
(new Application()).Run(loadWindow()) |> ignore