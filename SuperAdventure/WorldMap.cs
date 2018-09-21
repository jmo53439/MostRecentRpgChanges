using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class WorldMap : Form
    {
        readonly Assembly _thisAssembly = Assembly.GetExecutingAssembly();

        public WorldMap(Player player)
        {
            InitializeComponent();

            SetImage(pic_0_2, player.LocationsVisited.Contains(5) ? "picHerbalistsGarden" : "picFogLocation");
            SetImage(pic_1_2, player.LocationsVisited.Contains(4) ? "picHerbalistsHut" : "picFogLocation");
            SetImage(pic_2_0, player.LocationsVisited.Contains(7) ? "picFarmFields" : "picFogLocation");
            SetImage(pic_2_1, player.LocationsVisited.Contains(6) ? "picFarmHouse" : "picFogLocation");
            SetImage(pic_2_2, player.LocationsVisited.Contains(2) ? "picTownSquare" : "picFogLocation");
            SetImage(pic_2_3, player.LocationsVisited.Contains(3) ? "picTownGate" : "picFogLocation");
            SetImage(pic_2_4, player.LocationsVisited.Contains(8) ? "picBridge" : "picFogLocation");
            SetImage(pic_2_5, player.LocationsVisited.Contains(9) ? "picSpiderForest" : "picFogLocation");
            SetImage(pic_3_2, player.LocationsVisited.Contains(1) ? "picHome" : "picFogLocation");
        }

        private void SetImage(PictureBox pictureBox, string imageName)
        {
            using (Stream resourceStream =
                _thisAssembly.GetManifestResourceStream(
                    _thisAssembly.GetName().Name + ".Images." + imageName + ".jpg"))
            {
                if (resourceStream != null)
                {
                    pictureBox.Image = new Bitmap(resourceStream);
                }
            }
        }
    }
}
