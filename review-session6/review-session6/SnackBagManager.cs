using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6
{
    class SnackBagManager
    {
        private List<SnackBag> SnackBox = new List<SnackBag>();
        public void CreateNewBag()
        {
            SnackBag newBag = new SnackBag();
            SnackBox.Add(newBag);
        }

        public SnackBag GetSnackBag()
        {
            if (SnackBox.Count == 0)
            {
                CreateNewBag();
            }
            SnackBag FirstBag = SnackBox[0];
            SnackBox.RemoveAt(0);

            return FirstBag;
        }

    }
}
