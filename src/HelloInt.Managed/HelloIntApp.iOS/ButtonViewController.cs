using System;
using System.Drawing;

using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace HelloIntApp
{
    [Register("ButtonViewController")]
    public class ButtonViewController : UIViewController
    {
        public ButtonViewController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        //int m_clickCount;
        HelloInt.HelloInt m_helloInt;
        public override void ViewDidLoad()
        {
            //View = new UIView();

            UIButton button = UIButton.FromType(UIButtonType.System);
            button.SetTitle("Click me!", UIControlState.Normal);
            button.TouchUpInside += (o, e) =>
                {
                    //m_clickCount++;
                    var clickCount = m_helloInt.GetValue();
                    clickCount++;
                    m_helloInt.SetValue(clickCount);
                    button.SetTitle(string.Format("{0} clicks!", clickCount), UIControlState.Normal);
                };

            //View.AddSubview(button);
            m_helloInt = new HelloInt.HelloInt();
            View = button;

            base.ViewDidLoad();

            // Perform any additional setup after loading the view
        }
    }
}