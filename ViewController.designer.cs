// WARNING
//
// This file has been generated automatically by Xamarin Studio Community to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CocoaXamarinMacApp1
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSLevelIndicator levelIndicator { get; set; }

		[Action ("btnPridatClicked:")]
		partial void btnPridatClicked (AppKit.NSButton sender);

		[Action ("btnUbratClicked:")]
		partial void btnUbratClicked (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (levelIndicator != null) {
				levelIndicator.Dispose ();
				levelIndicator = null;
			}
		}
	}
}
