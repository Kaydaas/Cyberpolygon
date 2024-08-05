namespace Cyberpolygon.Models
{
    public class Configuration
    {
        public int Id { get; set; }
        public string AutounattendPath { get; set; }
        public string VmTitle { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public int CoresNumber { get; set; }
        public int RamNumber { get; set; }
        public int DiskSizeNumber { get; set; }
        public string IsoFilename { get; set; }
        public string OS { get; set; }
        public bool prox { get; set; }
        public bool zip { get; set; }
        public bool ziptest { get; set; }
        public bool zipmsi { get; set; }
        public bool cobian { get; set; }
        public bool folder { get; set; }
        public bool ftp { get; set; }
        public bool port80 { get; set; }
        public bool port445 { get; set; }
        public bool port3389 { get; set; }
        public bool ports804438080 { get; set; }
        public bool ports3389445 { get; set; }
        public bool ports3389445443 { get; set; }
        public bool pass { get; set; }
        public bool postgresql { get; set; }
        public bool powershell { get; set; }
        public bool veeam { get; set; }
        public bool hotfix7 { get; set; }
        public bool hotfix812 { get; set; }
    }
}
