using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creates a seed number that willbe used in the dealcard method so
        //it returns different card values
        int seednum = (int)DateTime.Now.Ticks;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adds all 52 cards pictures to the image list
            CardPicList.Add(Properties.Resources._1);
            CardPicList.Add(Properties.Resources._2);
            CardPicList.Add(Properties.Resources._3);
            CardPicList.Add(Properties.Resources._4);
            CardPicList.Add(Properties.Resources._5);
            CardPicList.Add(Properties.Resources._6);
            CardPicList.Add(Properties.Resources._7);
            CardPicList.Add(Properties.Resources._8);
            CardPicList.Add(Properties.Resources._9);
            CardPicList.Add(Properties.Resources._10);
            CardPicList.Add(Properties.Resources._11);
            CardPicList.Add(Properties.Resources._12);
            CardPicList.Add(Properties.Resources._13);
            CardPicList.Add(Properties.Resources._14);
            CardPicList.Add(Properties.Resources._15);
            CardPicList.Add(Properties.Resources._16);
            CardPicList.Add(Properties.Resources._17);
            CardPicList.Add(Properties.Resources._18);
            CardPicList.Add(Properties.Resources._19);
            CardPicList.Add(Properties.Resources._20);
            CardPicList.Add(Properties.Resources._21);
            CardPicList.Add(Properties.Resources._22);
            CardPicList.Add(Properties.Resources._23);
            CardPicList.Add(Properties.Resources._24);
            CardPicList.Add(Properties.Resources._25);
            CardPicList.Add(Properties.Resources._26);
            CardPicList.Add(Properties.Resources._27);
            CardPicList.Add(Properties.Resources._28);
            CardPicList.Add(Properties.Resources._29);
            CardPicList.Add(Properties.Resources._30);
            CardPicList.Add(Properties.Resources._31);
            CardPicList.Add(Properties.Resources._32);
            CardPicList.Add(Properties.Resources._33);
            CardPicList.Add(Properties.Resources._34);
            CardPicList.Add(Properties.Resources._35);
            CardPicList.Add(Properties.Resources._36);
            CardPicList.Add(Properties.Resources._37);
            CardPicList.Add(Properties.Resources._38);
            CardPicList.Add(Properties.Resources._38);
            CardPicList.Add(Properties.Resources._40);
            CardPicList.Add(Properties.Resources._41);
            CardPicList.Add(Properties.Resources._42);
            CardPicList.Add(Properties.Resources._43);
            CardPicList.Add(Properties.Resources._44);
            CardPicList.Add(Properties.Resources._45);
            CardPicList.Add(Properties.Resources._46);
            CardPicList.Add(Properties.Resources._47);
            CardPicList.Add(Properties.Resources._48);
            CardPicList.Add(Properties.Resources._49);
            CardPicList.Add(Properties.Resources._50);
            CardPicList.Add(Properties.Resources._51);
            CardPicList.Add(Properties.Resources._52);

            //Adds the first 4 card values which are aces to the card value list
            CardValueList.Add(11);
            CardValueList.Add(11);
            CardValueList.Add(11);
            CardValueList.Add(11);
            //Adds the next 4 card values which are Kings to the card value list
            CardValueList.Add(10);
            CardValueList.Add(10);
            CardValueList.Add(10);
            CardValueList.Add(10);
            //Adds the next 4 card values which are queens to the card value list
            CardValueList.Add(10);
            CardValueList.Add(10);
            CardValueList.Add(10);
            CardValueList.Add(10);

            //Adds the next 4 card values which are Jacks to the card value list
            CardValueList.Add(10);
            CardValueList.Add(10);
            CardValueList.Add(10);
            CardValueList.Add(10);

            //Adds the next 4 card values which are 10s to the card value list
            CardValueList.Add(10);
            CardValueList.Add(10);
            CardValueList.Add(10);
            CardValueList.Add(10);

            //Adds the next 4 card values which are 9s to the card value list
            CardValueList.Add(9);
            CardValueList.Add(9);
            CardValueList.Add(9);
            CardValueList.Add(9);

            //Adds the next 4 card values which are 8s to the card value list
            CardValueList.Add(8);
            CardValueList.Add(8);
            CardValueList.Add(8);
            CardValueList.Add(8);

            //Adds the next 4 card values which are 7s to the card value list
            CardValueList.Add(7);
            CardValueList.Add(7);
            CardValueList.Add(7);
            CardValueList.Add(7);

            //Adds the next 4 card values which are 6s to the card value list
            CardValueList.Add(6);
            CardValueList.Add(6);
            CardValueList.Add(6);
            CardValueList.Add(6);

            //Adds the next 4 card values which are 5s to the card value list
            CardValueList.Add(5);
            CardValueList.Add(5);
            CardValueList.Add(5);
            CardValueList.Add(5);

            //Adds the next 4 card values which are 4s to the card value list
            CardValueList.Add(4);
            CardValueList.Add(4);
            CardValueList.Add(4);
            CardValueList.Add(4);

            //Adds the next 4 card values which are 3s to the card value list
            CardValueList.Add(3);
            CardValueList.Add(3);
            CardValueList.Add(3);
            CardValueList.Add(3);

            //Adds the next 4 card values which are 2s to the card value list
            CardValueList.Add(2);
            CardValueList.Add(2);
            CardValueList.Add(2);
            CardValueList.Add(2);

        }
        //Defines a image list to store the picture of the cards
        List<Image> CardPicList = new List<Image>();

        //Defines a corresponding list to hold the value of the cards
        List<int> CardValueList = new List<int>();

        // initialize all of our variables
        int randomCard = 0;

        // player vars
        int cardTotal = 0;
        int cardValue = 0;
        int randomCard2 = 1;
        int cardValue2 = 0;
        int hitCard1 = 0;
        int hitCardValue1 = 0;
        int hitCard2 = 0;
        int hitCardValue2 = 0;
        int hitCard3 = 0;
        int hitCardValue3 = 0;

        // dealer vars
        int dealerTotal = 0;
        int dealerCard1 = 0;
        int dealerCard2 = 0;
        int dealerCard3 = 0;
        int dealerCard4 = 0;
        int dealerCard5 = 0;
        int dealerCardValue1 = 0;
        int dealerCardValue2 = 0;
        int dealerCardValue3 = 0;
        int dealerCardValue4 = 0;
        int dealerCardValue5 = 0;


        int hitCount = 0; // keeps track of our hits
        int dealerHitCount = 0; // keeps track of their hits

        
        private void btnDeal_Click(object sender, EventArgs e)
        {
            // Ensures cards are only dealt once.
            if(cardValue==0){
                // reset our hit count and set our hand value to 0
                hitCount = 0;
                cardTotal = 0;

                // resets their hit count and sets their hand value to 0
                dealerHitCount = 0;
                dealerTotal = 0;

                //gets 2 random numbers from the dealcard method
                randomCard = DealCard();
                randomCard2 = DealCard();

                //assigns values to the two cards from the Card value List
                cardValue = CardValueList[randomCard];
                cardValue2 = CardValueList[randomCard2];

                //assigns a picture to the card from the Card picture List
                pictureBox1.Image = CardPicList[randomCard];

                // displays our flipped card
                pictureBox2.Image = Properties.Resources.b2fv;

                //adds the the value of the first card to cardTotal
                cardTotal += cardValue;

                // display our hands total
                txtTotal.Text = cardTotal.ToString();


                dealerCard1 = DealCard();
                dealerCardValue1 = CardValueList[dealerCard1];
                pictureBoxDealer1.Image = CardPicList[dealerCard1];
                dealerTotal += dealerCardValue1;

                dealerCard2 = DealCard();
                dealerCardValue2 = CardValueList[dealerCard2];
                pictureBoxDealer2.Image = Properties.Resources.b2fv;

                txtDealerTotal.Text = dealerTotal.ToString();
            } // Deals 2 cards to both parties

            aceCheck();
            
            if (cardTotal + cardValue2 == 21 && dealerTotal + dealerCardValue2 != 21) {
                hiddenFlip();
                dealerFlip();
                MessageBox.Show("You got blackjack, you win the turn");
                reset();
            }  // if blackJack is drawn on deal and dealer doesn't have blackjack.

            if (dealerTotal + dealerCardValue2 == 21)
            {
                dealerFlip();
                hiddenFlip();
                MessageBox.Show("You Lose, Dealer Has Blackjack.");
                reset();
            } // if dealer has black jack

        } // Starts the game


        private void hiddenFlip() {
            // assign the card it's picture
            pictureBox2.Image = CardPicList[randomCard2]; // update the cards image

            cardTotal = cardTotal + cardValue2; // update our hands total value

            cardValue2 = 0; // once added make the value 0 to prevent readding our cards value to our hand

            txtTotal.Text = cardTotal.ToString();   // reDisplay our total
        }   // method used to flip our hidden card


        private void FlipHiddenCard(object sender, EventArgs e) {
            hiddenFlip();   // call to our flip hidden card method

        } // flips our hidden card on click


        public int DealCard()
        {
            int mynumber;

            //Creates a random object called randy1
            Random randy1 = new Random(seednum);
            mynumber = randy1.Next(52);
            seednum += 100;
            return mynumber;
        }    // Method for dealing cards

        
        private void btnHit_Click(object sender, EventArgs e)
        {
            // conditions for whether play can hit or not
            if (hitCount < 3 && cardTotal != 0)
            {
                // if it's our first hit, update the first card
                if (hitCount == 0 && cardTotal < 21 && cardValue + cardValue2 < 21) {

                    hiddenFlip(); // flip hidden card if it's not already flipped, if flipped value should be 0 so it won't readd the value of the card

                    hitCard1 = DealCard();                      // get random Value
                    hitCardValue1 = CardValueList[hitCard1];    // draw card value from list
                    pictureBox3.Image = CardPicList[hitCard1];  // draw card image from list

                    cardTotal += hitCardValue1;                 // update hand value
                    txtTotal.Text = cardTotal.ToString();       // update the displayed hand value

                    aceCheck();                                 // check for aces if player goes bust with an ace.

                    if (cardTotal > 21)
                    {
                        txtTotal.Text = cardTotal.ToString();   // update the displayed hand value
                        MessageBox.Show("Dealer wins, you've gone bust.");
                        reset();
                    }

                }

                // if it's our second hit, update the second card
                if (hitCount == 1 && cardTotal < 21 && cardValue + cardValue2 + hitCardValue1 < 21)
                {
                    hitCard2 = DealCard();                      // get random Value

                    hitCardValue2 = CardValueList[hitCard2];    // draw card value from list
                    pictureBox4.Image = CardPicList[hitCard2];  // draw card image from list

                    cardTotal += hitCardValue2;                 // update hand value
                    txtTotal.Text = cardTotal.ToString();       // update the displayed hand value

                    aceCheck();                                 // check for aces if player goes bust with an ace.

                    if (cardTotal > 21)
                    {
                        txtTotal.Text = cardTotal.ToString();   // update the displayed hand value
                        MessageBox.Show("Dealer wins, you've gone bust.");
                        reset();
                    }

                }

                // if it's our first hit, update the first card
                if (hitCount == 2 && cardTotal < 21)
                {
                    hitCard3 = DealCard();                      // get random Value
                    hitCardValue3 = CardValueList[hitCard3];    // draw card value from list
                    pictureBox5.Image = CardPicList[hitCard3];  // draw card image from list

                    cardTotal += hitCardValue3;                 // update hand value
                    txtTotal.Text = cardTotal.ToString();       // update the displayed hand value   

                    aceCheck();                                 // check for aces if player goes bust with an ace.

                    if (cardTotal > 21)
                    {
                        txtTotal.Text = cardTotal.ToString();   // update the displayed hand value
                        MessageBox.Show("Dealer wins, you've gone bust.");
                        reset();
                    }

                }

                hitCount += 1;  // update our hit count
                

            }


        }  // Player Draws a card


        private void reset()
        {
            // reset game variables to default state
            cardTotal = 0;
            cardValue = 0;
            cardValue2 = 0;

            dealerTotal = 0;
            dealerCardValue1 = 0;
            dealerCardValue2 = 0;
            

            // reset players cards to default state
            pictureBox1.Image = Properties.Resources.b2fv;
            pictureBox2.Image = Properties.Resources.b2fv;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;

            // reset dealers cards to default state
            pictureBoxDealer1.Image = Properties.Resources.b2fv;
            pictureBoxDealer2.Image = Properties.Resources.b2fv;
            pictureBoxDealer3.Image = null;
            pictureBoxDealer4.Image = null;
            pictureBoxDealer5.Image = null;

            txtTotal.Text = cardTotal.ToString();   // update card total
            txtDealerTotal.Text = dealerTotal.ToString();

        }      // reset method, resets to start


        private void aceCheck()
        {
            // player cards

            if (cardTotal > 21 && cardValue == 11)  // if card 1 is an ace and handTotal exceeds, 21
            {
                cardValue = 1;
                cardTotal -= 10;
                txtTotal.Text = cardTotal.ToString();
            }

            if (cardTotal > 21 && cardValue2 == 11) // if card 2 is an ace and handTotal exceeds, 21
            {
                cardValue2 = 1;
                cardTotal -= 10;
                txtTotal.Text = cardTotal.ToString();
            }

            if (cardTotal > 21 && hitCardValue1 == 11) // if card 3 is an ace and handTotal exceeds, 21
            {
                hitCardValue1 = 1;
                cardTotal -= 10;
                txtTotal.Text = cardTotal.ToString();
            }

            if (cardTotal > 21 && hitCardValue2 == 11) // if card 4 is an ace and handTotal exceeds, 21
            {
                hitCardValue2 = 1;
                cardTotal -= 10;
                txtTotal.Text = cardTotal.ToString();
            }

            if (cardTotal > 21 && hitCardValue3 == 11) // if card 5 is an ace and handTotal exceeds, 21
            {
                hitCardValue3 = 1;
                cardTotal -= 10;
                txtTotal.Text = cardTotal.ToString();
            }



            // dealer cards

            if (dealerTotal > 21 && dealerCardValue1 == 11)  // if card 1 is an ace and handTotal exceeds, 21
            {
                dealerCardValue1 = 1;
                dealerTotal -= 10;
                txtDealerTotal.Text = dealerTotal.ToString();
            }

            if (dealerTotal > 21 && dealerCardValue2 == 11)  // if card 2 is an ace and handTotal exceeds, 21
            {
                dealerCardValue2 = 1;
                dealerTotal -= 10;
                txtDealerTotal.Text = dealerTotal.ToString();
            }

            if (dealerTotal > 21 && dealerCardValue3 == 11)  // if card 3 is an ace and handTotal exceeds, 21
            {
                dealerCardValue3 = 1;
                dealerTotal -= 10;
                txtDealerTotal.Text = dealerTotal.ToString();
            }

            if (dealerTotal > 21 && dealerCardValue4 == 11)  // if card 4 is an ace and handTotal exceeds, 21
            {
                dealerCardValue4 = 1;
                dealerTotal -= 10;
                txtDealerTotal.Text = dealerTotal.ToString();
            }

            if (dealerTotal > 21 && dealerCardValue5 == 11)  // if card 5 is an ace and handTotal exceeds, 21
            {
                dealerCardValue5 = 1;
                dealerTotal -= 10;
                txtDealerTotal.Text = dealerTotal.ToString();
            }













        }   // method to make aces a 1 if value exceeds 21


        private void dealersTurn()   // calculates the dealers turn 
        {
            dealerFlip();  // flip dealers hidden card and redisplay their hand value

            if (dealerTotal < 17 && dealerHitCount == 0) // dealers first hit
            {
                                                                            // Dealers hit pattern
                                                                            //
                dealerCard3 = DealCard();                                   // deal the dealer a hit card
                dealerCardValue3 = CardValueList[dealerCard3];              // assign the value of it
                pictureBoxDealer3.Image = CardPicList[dealerCard3];         // assign the pic of it
                dealerTotal += dealerCardValue3;                            // update the total
                txtDealerTotal.Text = dealerTotal.ToString();               // redisplay
                dealerHitCount += 1;                                        // increment the hit counter
                aceCheck();                                                 // ace condition check
                                                                            // Repeat the process until dealer total is at least 17
            }

            if (dealerTotal < 17 && dealerHitCount == 1) // dealers second hit
            {
                dealerCard4 = DealCard();
                dealerCardValue4 = CardValueList[dealerCard4];
                pictureBoxDealer4.Image = CardPicList[dealerCard4];
                dealerTotal += dealerCardValue4;
                txtDealerTotal.Text = dealerTotal.ToString();
                dealerHitCount += 1;
                aceCheck();
            }

            if (dealerTotal < 17 && dealerHitCount == 2) // dealers third and max hit
            {
                dealerCard5 = DealCard();
                dealerCardValue5 = CardValueList[dealerCard5];
                pictureBoxDealer5.Image = CardPicList[dealerCard5];
                dealerTotal += dealerCardValue5;
                txtDealerTotal.Text = dealerTotal.ToString();
                dealerHitCount += 1;
                aceCheck();
            }

            dealerBustCheck();  // check if dealer went bust during their turn

        }


        private void dealerFlip()    // method to flip the dealers hidden card 
        {
            pictureBoxDealer2.Image = CardPicList[dealerCard2]; // 
            aceCheck();                                         // ace condition check
            dealerTotal += dealerCardValue2;                    // update dealers total
            txtDealerTotal.Text = dealerTotal.ToString();       // redisplay dealers total
        }


        private void dealerBustCheck() {
            if (dealerTotal > 21)
            {
                txtDealerTotal.Text = dealerTotal.ToString();
                MessageBox.Show("Dealer's gone bust, Player wins the round");
                reset();
            }
        }  // method to check if dealers gone bust

       
        private void btnStay_Click(object sender, EventArgs e)
        {
            if (cardValue != 0)
            {
                hiddenFlip();  // if our card isn't flipped flip it
                dealersTurn(); // calculate the dealers turn
                calcWinner();  // calculate the winner of the game and reset 
            }

            
        }  // Initiates Dealers turn unless user get's to 21


        private void calcWinner()
        {
            if (cardTotal > dealerTotal && cardValue != 0)
            {
                txtDealerTotal.Text = dealerTotal.ToString(); // update the dealers total for final display
                MessageBox.Show("Player wins the round");
                reset();
            } // player wins

            if (dealerTotal >= cardTotal && cardValue != 0)
            {
                txtDealerTotal.Text = dealerTotal.ToString(); // update the dealers total for final display
                MessageBox.Show("Dealer wins the round");
                reset();
            } // dealer wins or is draw so dealer still wins
        }

    }   // form
}
