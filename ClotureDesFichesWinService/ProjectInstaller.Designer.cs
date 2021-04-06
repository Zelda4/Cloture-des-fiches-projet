namespace ClotureDesFichesWinService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClotureDesFichesWinServiceProcess = new System.ServiceProcess.ServiceProcessInstaller();
            this.ClotureDesFichesWinService = new System.ServiceProcess.ServiceInstaller();
            // 
            // ClotureDesFichesWinServiceProcess
            // 
            this.ClotureDesFichesWinServiceProcess.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ClotureDesFichesWinServiceProcess.Password = null;
            this.ClotureDesFichesWinServiceProcess.Username = null;
            // 
            // ClotureDesFichesWinService
            // 
            this.ClotureDesFichesWinService.DisplayName = "ClotureDesFichesWinService";
            this.ClotureDesFichesWinService.ServiceName = "ClotureDesFichesWinService";
            this.ClotureDesFichesWinService.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ClotureDesFichesWinServiceProcess,
            this.ClotureDesFichesWinService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ClotureDesFichesWinServiceProcess;
        private System.ServiceProcess.ServiceInstaller ClotureDesFichesWinService;
    }
}