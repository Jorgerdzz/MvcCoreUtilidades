namespace MvcCoreUtilidades.Helpers
{
    //Enumeracion con las carpetas que deseemos subir ficheros

    public enum Folders { Uploads, Images, Facturas}

    public class HelperPathProvider
    {
        private IWebHostEnvironment hostEnvironment;

        public HelperPathProvider(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        //TENDREMOS UN METODO QUE SE ENCARGARA DE RESOLVER LA RUTA
        //COMO UN STRING CUANDO RECIBAMOS EL FICHERO Y LA CARPETA
        public string MapPath(string fileName, Folders folder)
        {
            string carpeta = "";
            if(folder == Folders.Images)
            {
                carpeta = "images";
            }else if(folder == Folders.Uploads)
            {
                carpeta = "uploads";
            }else if(folder == Folders.Facturas)
            {
                carpeta = "facturas";
            }
            string rootPath = this.hostEnvironment.WebRootPath;
            string path = Path.Combine(rootPath, carpeta, fileName);
            return path;
        }

    }
}
