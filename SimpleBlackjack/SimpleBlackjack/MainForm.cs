
using SimpleBlackjack.MoveToClassLibrary;
using System.Windows.Forms;

namespace SimpleBlackjack
{
    public partial class MainForm : Form
    {

        private GameController gc;
        public MainForm()
        {
            InitializeComponent();

            //Create a GameController object and send the MainForm object to it.
            gc = new GameController(this);
            hideAllCards();
        }

        public void test(String text)
        {
            MessageBox.Show(text);
        }

        private void startgame_btn_Click(object sender, EventArgs e)
        {
            startgame_btn.Enabled = false;
        }

        private void deal_btn_Click(object sender, EventArgs e)
        {
            gc.deal();
            deal_btn.Enabled = false;
        }

        private void hit_btn_Click(object sender, EventArgs e)
        {
            gc.hit();
        }

        private void stand_btn_Click(object sender, EventArgs e)
        {
            gc.stand();
            stand_btn.Enabled = false;
        }

        public Button getStartBtn()
        {
            return this.startgame_btn;
        }

        public RichTextBox getBottomTxt()
        {
            return this.bottom_txtbox;
        }

        public Button getHitButton()
        {
            return this.hit_btn;
        }

        #region showCardsFunctions
        public void showCardsPlayer(Hand playerHand)
        {
            int count = 0;
            string currentCardPicture = "";

            if (gc.playerHand.cards != null && gc.playerHand != null)
                foreach (Card currentcard in gc.playerHand.cards)
                {
                    if (currentcard != null && currentcard.suit != "")
                    {
                        if (currentcard.value < 10)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 10)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 11)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 12)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value >= 13)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                    }
                    else
                        currentCardPicture = "space";
                    if (count == 0)
                    {
                        card1_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card1_box.Image = myImage;
                        card1_box.SizeMode =
                       PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 1)
                    {
                        card2_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card2_box.Image = myImage;
                    }
                    if (count == 2)
                    {
                        card3_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card3_box.Image = myImage;
                    }
                    if (count == 3)
                    {
                        card4_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card4_box.Image = myImage;
                    }
                    if (count == 4)
                    {
                        card5_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card5_box.Image = myImage;
                    }
                    if (count == 5)
                    {
                        card6_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card6_box.Image = myImage;
                    }
                    if (count == 6)
                    {
                        card7_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card7_box.Image = myImage;
                    }
                    if (count == 7)
                    {
                        card1_box.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card1_box.Image = myImage;
                    }
                    if (count == 8)
                    {
                        card2_box.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card2_box.Image = myImage;
                    }
                    if (count == 9)
                    {
                        card3_box.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentCardPicture);
                        card3_box.Image = myImage;

                    }
                    if (count == 10)
                    {
                        card4_box.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card4_box.Image = myImage;
                    }
                    if (count == 11)
                    {
                        card5_box.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        card5_box.Image = myImage;
                    }
                    count++;
                }
        }

        public void showCardsDealer(Hand dealerHand)
        {
            int count = 0;
            string currentCardPicture = "";

            if (gc.playerHand.cards != null && gc.playerHand != null)
                foreach (Card currentcard in gc.dealerHand.cards)
                {
                    if (currentcard != null && currentcard.suit != "")
                    {
                        if (currentcard.value < 10)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 10)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 11)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value == 12)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                        if (currentcard.value >= 13)
                            currentCardPicture = "0" + currentcard.value.ToString() + "_" + currentcard.suit;
                    }
                    else
                        currentCardPicture = "space";
                    if (count == 0)
                    {
                        dealer_box1.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box1.Image = myImage;
                        dealer_box1.SizeMode =
                       PictureBoxSizeMode.StretchImage;
                    }
                    if (count == 1)
                    {
                        dealer_box2.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box2.Image = myImage;
                    }
                    if (count == 2)
                    {
                        dealer_box3.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box3.Image = myImage;
                    }
                    if (count == 3)
                    {
                        dealer_box4.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box4.Image = myImage;
                    }
                    if (count == 4)
                    {
                        dealer_box5.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box5.Image = myImage;
                    }
                    if (count == 5)
                    {
                        dealer_box1.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box1.Image = myImage;
                    }
                    if (count == 6)
                    {
                        dealer_box2.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box2.Image = myImage;
                    }
                    if (count == 7)
                    {
                        dealer_box3.Visible = true;
                        System.Resources.ResourceManager rm =
                       SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box3.Image = myImage;
                    }
                    if (count == 8)
                    {
                        dealer_box4.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box4.Image = myImage;
                    }
                    if (count == 9)
                    {
                        dealer_box5.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage = (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box5.Image = myImage;

                    }
                    if (count == 10)
                    {
                        dealer_box1.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box1.Image = myImage;
                    }
                    if (count == 11)
                    {
                        dealer_box2.Visible = true;
                        System.Resources.ResourceManager rm =
                        SimpleBlackjack.Properties.Resources.ResourceManager;
                        Bitmap myImage =
                       (Bitmap)rm.GetObject(currentCardPicture);
                        dealer_box2.Image = myImage;
                    }
                    count++;
                }
        }
        #endregion

        public void hideAllCards()
        {
            card1_box.Visible = false;
            card2_box.Visible = false;
            card3_box.Visible = false;
            card4_box.Visible = false;
            card5_box.Visible = false;
            card6_box.Visible = false;
            card7_box.Visible = false;
            dealer_box1.Visible = false;
            dealer_box2.Visible = false;
            dealer_box3.Visible = false;
            dealer_box4.Visible = false;
            dealer_box5.Visible = false;
        }
    }
}