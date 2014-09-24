using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

using Windows.UI.Xaml.Shapes;
using System.IO;

namespace BackgroundTasks
{
    public sealed class TileUpdater : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            var defferal = taskInstance.GetDeferral();

            Random ran = new Random();
            int r = ran.Next(1, 56800);

            ToastTemplateType toastType = ToastTemplateType.ToastImageAndText02;
            XmlDocument toastXML = ToastNotificationManager.GetTemplateContent(toastType);
            XmlNodeList toastText = toastXML.GetElementsByTagName("text");
            XmlNodeList toastImages = toastXML.GetElementsByTagName("image");

                        toastText[0].InnerText = "Expert Tamil Dictionary";
                        toastText[1].InnerText = r.ToString(); ;
               

            ((XmlElement)toastImages[0]).SetAttribute("src", "ms-appx:///Assets/Storelogo.png");
            // ((XmlElement)toastImages[0]).SetAttribute("alt", "Scary Cat Face");

            ToastNotification toast = new ToastNotification(toastXML);

            ToastNotificationManager.CreateToastNotifier().Show(toast);

            defferal.Complete();
        }
    }
}
