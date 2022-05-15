using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DuckDnsAgent
{
    public class ConfigurationFile
    {
        public string userToken = "";
        public List<string> domainsToUpdate = new List<string>();
        public int updateInterval = 60;

        private string configurationFileLocation = Application.StartupPath + "\\config.json";

        public ConfigurationFile(bool autoLoad = true)
        {
            if (autoLoad) {
                if (Load() == false) {
                    Save();
                }
            }
        }

        public bool Save()
        {
            string jsonString;
            try {
                jsonString = JsonConvert.SerializeObject(this);
            } catch(Exception serializationException) {
                Debug.WriteLine("ConfigurationFile.Save() : serializationException" + Environment.NewLine + serializationException.Message);
                return false;
            }
            try {
                StreamWriter sw = new StreamWriter(this.configurationFileLocation);
                sw.Write(jsonString);
                sw.Close();
                return true;
            } catch (Exception writtingException) {
                Debug.WriteLine("ConfigurationFile.Save() : writtingException" + Environment.NewLine + writtingException.Message);
                return false;
            }
        }

        public bool Load()
        {
            if (!File.Exists(this.configurationFileLocation)) {
                Debug.WriteLine("ConfigurationFile.Load() : Configuration file doesn't exist at this location: " + this.configurationFileLocation);
                return false;
            }

            string jsonString;
            try {
                StreamReader sr = new StreamReader(this.configurationFileLocation);
                jsonString = sr.ReadToEnd();
                sr.Close();
            } catch (Exception readingException) {
                Debug.WriteLine("ConfigurationFile.Load() : readingException" + Environment.NewLine + readingException.Message);
                return false;
            }

            ConfigurationFile tempObject;
            try {
                tempObject = JsonConvert.DeserializeObject<ConfigurationFile>(jsonString);
            } catch (Exception deserializationException) {
                Debug.WriteLine("ConfigurationFile.Load() : deserializationException" + Environment.NewLine + deserializationException.Message);
                return false;
            }

            if (tempObject == null) { return false; }

            try {
                this.userToken = tempObject.userToken;
                this.domainsToUpdate = tempObject.domainsToUpdate;
                this.updateInterval = tempObject.updateInterval;
                return true;
            } catch (Exception importPropertiesException) {
                Debug.WriteLine("ConfigurationFile.Load() : importPropertiesException" + Environment.NewLine + importPropertiesException.Message);
                return false;
            }


        }

    }
}
