using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CollectionView
{
    public partial class MainPageViewModel
    {
        public MainPageViewModel()
        {
            prp_StockCards = new ObservableCollection<Models.StockCard>();
        }

        #region PROPERTIES

        private ObservableCollection<Models.StockCard> prp_StockCards;
        public ObservableCollection<Models.StockCard> StockCards
        {
            get
            {
                return prp_StockCards;
            }
            set
            {
                prp_StockCards = value;
            }
        }

        #endregion

        #region METHODS

        [RelayCommand]
        public async Task AddItem()
        {
            try
            {
                Models.StockCard tmp_StockCard = new Models.StockCard(u_Animate: true);
                prp_StockCards.Add(tmp_StockCard);
            }
            catch (Exception)
            {

                throw;
            }

            await Task.Delay(0);
        }

        #endregion
    }
}
