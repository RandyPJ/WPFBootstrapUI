using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WPFBootstrapUI.Controls.Modals
{
    public class ModalMananger
    {
        public static void ShowModal(Window ownerWindow, string title, string message, string acceptButtonText, string cancelButtonText)
        {
            if (ownerWindow == null)
                return;

            Modal modal = new Modal(ownerWindow)
            {
                Title = title,
                Message = message,
                AcceptButtonText = acceptButtonText,
                CancelButtonText = cancelButtonText
            };

            ownerWindow.Opacity = 0.6;

            ownerWindow.Dispatcher.Invoke(new Action(() => modal.ShowDialog())); 

            ownerWindow.Opacity = 1;
        }

        public static Task<bool?> ShowModalAsync(Window ownerWindow, string title, string message, string acceptButtonText, string cancelButtonText)
        {
            TaskCompletionSource<bool?> completionSource = new TaskCompletionSource<bool?>();

            Modal modal = new Modal(ownerWindow)
            {
                Title = title,
                Message = message,
                AcceptButtonText = acceptButtonText,
                CancelButtonText = cancelButtonText
            };

            ownerWindow.Opacity = 0.6;

            ownerWindow.Dispatcher.BeginInvoke(new Action(() => completionSource.SetResult(modal.ShowDialog())));
            
            ownerWindow.Opacity = 1;

            return completionSource.Task;
        }
    }
}
