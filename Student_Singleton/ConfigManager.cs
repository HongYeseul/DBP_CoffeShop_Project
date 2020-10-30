using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Singleton
{
    class ConfigManager
    {
        int idx;
        bool set;
        private static ConfigManager instance_ = new ConfigManager();

        public static ConfigManager GetInstance()
        {
            return instance_;
        }

        private ConfigManager() { }

        public int GetRecentlyUsedListIdx()
        {
            return idx;
        }

        public bool InitAuto()
        {
            set = Properties.Settings.Default.AutoSave;
            return set;
        }
        public int InitLastIdx()
        {
            idx = Properties.Settings.Default.LastIndex;
            Console.WriteLine(idx);
            return idx;
        }
        public void AutoSet(bool what)
        {
            Properties.Settings.Default.AutoSave = what;
            Properties.Settings.Default.Save();
        }

        public void LastLoadSet(int what)
        {
            Properties.Settings.Default.LastIndex = what;
            Properties.Settings.Default.Save();
        }
    }
}
