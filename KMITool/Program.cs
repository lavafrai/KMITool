namespace KMITool
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (!ContextValidator.validateArgs(args))
            {
                ShowError(Strings.ERROR_EMPTY_ARGS);
                return;
            }

            string filePath = args[0];
            if (!ContextValidator.validateFile(filePath))
            {
                ShowError(Strings.ERROR_INVALID_FILE);
                return;
            }

            FileUploader fileUploader = new FileUploader(filePath);
            if (!fileUploader.Upload())
            {
                ShowError(Strings.ERROR_UPLOAD_FAILED);
                return;
            } else
            {
                ShowSuccess(fileUploader.getLink());
            }
        }

        static void ShowSuccess(string message)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SuccessForm(message));
        }

        static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}