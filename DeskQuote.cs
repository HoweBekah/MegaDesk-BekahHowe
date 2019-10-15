using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_BekahHowe
{
    class DeskQuote : Desk
    {

        

        private Desk newDesk = new Desk();
        private string CustName;
        private DateTime QuoteDate;
        private int QuoteTotal;

        private int AreaSurface;

        #region deskquote constants
        private const int THRESHHOLD_S = 1000;
        private const int PER_DRAWER_PRICE = 50;
        private const int BASE_PRICE = 200;
        #endregion

        public DeskQuote(int width, int depth, int drawers, SurfaceMaterials material, int RushOrder)
        {
            newDesk.Width = width;
            newDesk.Depth = depth;
            newDesk.Drawers = drawers;
            AreaSurface = newDesk.Width * newDesk.Depth;
            newDesk.SurfaceMaterials = material;
            newDesk.RushOrder = RushOrder;
                }
        public int CostofDrawer() {
            return newDesk.Drawers * PER_DRAWER_PRICE;
        }

        public int QuoteCalculate() {
            return BASE_PRICE + CostofDrawer(); //+ SurplusSurfaceArea() + CostOfMaterials() + CostRushOrder()  
        }

        public int SurplusSurfaceArea()
        {
            return AreaSurface;

        }

        public int CostOfMaterials()
        {
            return AreaSurface;
        }

        public int CostRushOrder()
        {

            return RushOrder;
        }
    }
}
