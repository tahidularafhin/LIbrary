using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        void Add(Checkout newCheckout);

        IEnumerable<Checkout> GetAll();
        IEnumerable<CheckoutHistory> GetCheckoutsHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        Checkout GetById(int checkoutId);
        Checkout GetLatestCheckout(int assetId);


        string GetCurrentCheckoutPatron(int assetId);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);
        bool IsCheckedOut(int id);

        void CheckOutItem(int assetId, int libarayCardId);
        void CheckInItem(int assetId);
        void PlaceHold(int assetId, int libbraryCardId);

        void MarkLost(int assetId);
        void MarkFound(int assetId);
        string GetCurrentHoldPatron(int id);
    }
}
