using System;
using System.Threading.Tasks;
using System.Windows;

namespace WPFBootstrapUI.Controls.Modals
{
    public class ModalService
    {
        /// <summary>
        /// Shows a modal.
        /// </summary>
        /// <param name="ownerWindow">Represents the owner of the modal.</param>
        /// <param name="title">Title of the modal.</param>
        /// <param name="message">Content of the modal.</param>
        /// <param name="acceptButtonText">Accept button.</param>
        /// <param name="cancelButtonText">Cancel button.</param>
        /// <param name="isDesition">If true, the cancel button will be shown.</param>
        /// <returns></returns>
        public static ModalResult ShowModal(Window ownerWindow, string title, string message, string acceptButtonText, string cancelButtonText, bool isDesition)
        {
            if (ownerWindow == null)
                return ModalResult.None;

            Modal modal = new Modal(ownerWindow)
            {
                Title = title,
                Message = message,
                AcceptButtonText = acceptButtonText,
                CancelButtonText = cancelButtonText,
                IsDesition = isDesition
            };

            ownerWindow.Opacity = 0.6;
            ownerWindow.Dispatcher.Invoke(new Action(() => modal.ShowDialog()));
            ownerWindow.Opacity = 1;

            return modal.ModalResult;
        }

        /// <summary>
        /// Shows a modal asynchronously.
        /// </summary>
        /// <param name="ownerWindow">Represents the owner of the modal.</param>
        /// <param name="title">Title of the modal.</param>
        /// <param name="message">Content of the modal.</param>
        /// <param name="acceptButtonText">Accept button.</param>
        /// <param name="cancelButtonText">Cancel button.</param>
        /// <param name="isDesition">If true, the cancel button will be shown.</param>
        /// <returns></returns>
        public static async Task<ModalResult?> ShowModalAsync(Window ownerWindow, string title, string message, string acceptButtonText, string cancelButtonText, bool isDesition)
        {
            TaskCompletionSource<ModalResult?> modalResultSource = new TaskCompletionSource<ModalResult?>();

            Modal modal = new Modal(ownerWindow)
            {
                Title = title,
                Message = message,
                AcceptButtonText = acceptButtonText,
                CancelButtonText = cancelButtonText,
                IsDesition = isDesition
            };

            ownerWindow.Opacity = 0.6;

            await ownerWindow.Dispatcher.BeginInvoke(new Action(() => 
            {
                modal.ShowDialog();
                modalResultSource.SetResult(modal.ModalResult);
            }));

            ownerWindow.Opacity = 1;

            return await modalResultSource.Task;
        }
    }
}
