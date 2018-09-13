namespace SqueakyApp.Mac
open System
open Foundation
open AppKit
open Xamarin.Forms
open Xamarin.Forms.Platform.MacOS

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit FormsApplicationDelegate ()

    let mutable _window : NSWindow = null
    do
        let style = NSWindowStyle.Closable |||  NSWindowStyle.Resizable ||| NSWindowStyle.Titled
        let rect = CoreGraphics.CGRect(200., 1000., 1024., 768.)
        _window <- new NSWindow(rect, style, NSBackingStore.Buffered, false)
        _window.Title <- "Hello Fabulous Mac!"
        _window.TitleVisibility <- NSWindowTitleVisibility.Hidden

    override this.MainWindow =
        _window

    override this.DidFinishLaunching(notification) = 
        Forms.Init()
        this.LoadApplication(new SqueakyApp.App())
        base.DidFinishLaunching(notification)
