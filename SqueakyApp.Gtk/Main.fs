namespace SqueakyApp.Gtk
    module Main =

        open System
        open Xamarin.Forms
        open Xamarin.Forms.Platform.GTK

        [<EntryPoint>]
        let Main(args) =
            Gtk.Application.Init()
            Forms.Init()

            let app = new SqueakyApp.App()
            let window = new FormsWindow()
            window.LoadApplication(app)
            window.SetApplicationTitle("Hello Fabulous Linux")
            window.Show();

            Gtk.Application.Run()
            0
