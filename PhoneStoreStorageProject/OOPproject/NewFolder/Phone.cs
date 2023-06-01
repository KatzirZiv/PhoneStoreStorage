
namespace OOPproject.NewFolder
{
    public class Phone : ElectricItem
    {
        private int Ssd { get; set; }
        private double Inch { get; set; }
        private bool SupportsWirelessCharging { get; set; }
        private int CameraResolution { get; set; }
        public Phone(string name = "Iphone", int ssd = 64, string color = "White", double inch = 2.4, bool supportsWirelessCharging = true, int cameraResolution = 1240)
            : base(ssd, cameraResolution, name, color)
        {
            SetSsd(ssd);
            SetInch(inch);
            SetWireless(supportsWirelessCharging);
            SetCameraResolution(cameraResolution);
            switch (ssd)
            {
                case 64:
                    SetPrice(64 * 50.35);
                    SetId(1000 + (int)(inch * 5));
                    break;
                case 128:
                    SetPrice(128 * 30.35);
                    SetId(1000 + (int)(inch * 6));
                    break;
                case 256:
                    SetPrice(256 * 19.45);
                    SetId(1000 + (int)(inch * 7));
                    break;
                case 512:
                    SetPrice(512 * 11.55);
                    SetId(1000 + (int)(inch * 8));
                    break;
                case 1024:
                    SetPrice(1024 * 5.75);
                    SetId(1000 + (int)(inch * 8));
                    break;
                default:
                    break;
            }
        }
        private int GetSsd() { return Ssd; }
        private double GetInch() { return Inch; }
        private bool GetWireless() { return  SupportsWirelessCharging; }
        private int GetCameraResolution() { return CameraResolution; }

        private void SetSsd(int ssd) { Ssd= ssd; }
        private void SetInch(double inch) { Inch = inch; }
        private void SetWireless(bool wireless) { SupportsWirelessCharging=wireless; }
        private void SetCameraResolution(int camera) {  CameraResolution=camera; }

        public override string ToString()
        {
            return $"{GetName()} Details, ID: {GetId()} Price: {GetPrice()} Inch: {GetInch()} Color: {GetColor()} Wireless: {SupportsWirelessCharging} SSD: {Ssd} Resolution: {CameraResolution}";
        }
    }
}


