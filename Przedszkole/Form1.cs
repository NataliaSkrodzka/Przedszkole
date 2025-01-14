using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Przedszkole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Node head;
        private string wyswietl;

        private void WyswietlWszystkich_Click(object sender, EventArgs e)
        {
            WyswietlWszystkich();
            MessageBox.Show(wyswietl);
        }
        public string WyswietlWszystkich()

        {

            Node temp = head;
            if (temp == null)
            {
                wyswietl = "Lista jest pusta";
                return wyswietl;
            }
            wyswietl = "Lista przedszkolaków:";
            int i = 1;
            while (temp != null)
            {
                wyswietl += "\n" + i + " " + temp.ImieInazwisko+ ", saldo: " +temp.Saldo;
                temp = temp.Next;
                i++;
            }
            return wyswietl;


        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            string imieInazwisko = wpisywanieDodaj.Text.ToString();
            string wiadomosc=DodajPrzedszkolaka(imieInazwisko);
            MessageBox.Show(wiadomosc);
            wpisywanieDodaj.Clear();
        }
        public string DodajPrzedszkolaka(string imieInazwisko)
        {
            string wiadomosc;
            if (imieInazwisko.Length==0)
            {
                wiadomosc = "Wpisz przynajmniej 1-literowe imie";
                return wiadomosc;
            }
            else
            {
                Node newNode = new Node(imieInazwisko);
                if (head == null)
                {
                    head = newNode;
                    wiadomosc = "dodano";
                    return wiadomosc;
                }
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Prev = temp;
            }
            wiadomosc = "dodano";
            return wiadomosc;
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            string imieInazwisko = wpisywanieUsun.Text.ToString();
            string wiadomosc = UsunPrzedszkolaka(imieInazwisko);
            MessageBox.Show(wiadomosc);
            wpisywanieUsun.Clear();
        }
        public string UsunPrzedszkolaka(string imieInazwisko)
        {
            string wiadomosc;
            Node temp = head;
            while (temp != null && temp.ImieInazwisko != imieInazwisko)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                wiadomosc = "Przedszkolak: "+imieInazwisko + " nie zostal znaleziony";
                return wiadomosc;
            }
            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
            else
            {
                head = temp.Next;

                //jesli to pierwszy element
            }
            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }
            wiadomosc = $"Przedszkolak '{imieInazwisko}' został usunięty";
            return wiadomosc;
        }

        private void Wyszukaj_Click(object sender, EventArgs e)
        {
            string imieInazwisko = wpisywanieWyszukaj.Text.ToString();
            WyszukajPrzedszkolaka(imieInazwisko);
            MessageBox.Show(wyswietl);
        }

        public string WyszukajPrzedszkolaka(string imieInazwisko)
        {
            Node temp = head;

            while(temp != null)
            {
                if(temp.ImieInazwisko == imieInazwisko)
                {
                    wyswietl= temp.ImieInazwisko+ ", saldo: "+temp.Saldo;
                    return wyswietl;
                }
                temp = temp.Next;
            }
            wyswietl = $"Przedszkolak'{imieInazwisko}' nie został znaleziony";
            return wyswietl;
        }

        private void Zmien_Click(object sender, EventArgs e)
        {
            string wpisywanaKwota=wpisywanieZmien.Text.ToString();
            double kwota = 0;
            if (wpisywanaKwota.Length > 0)
            {
                kwota = Convert.ToDouble(wpisywanaKwota);
            }
            ZmienSaldo(kwota);
            MessageBox.Show(wyswietl);
            wpisywanieWyszukaj.Clear();
            wpisywanieZmien.Clear();
        }

        public string ZmienSaldo(double kwota)
        {
            Node temp = head;
            if (temp == null)
            {
                wyswietl = "Lista jest pusta";
                return wyswietl;
            }
            string imieInazwisko = wpisywanieWyszukaj.Text.ToString();
            if (imieInazwisko.Length == 0)
            {
                wyswietl = "najpierw wyszukaj przedszkolaka";
            }
            else
            {
                while (temp != null)
                {
                    if (temp.ImieInazwisko == imieInazwisko)
                    {
                        temp.Saldo += kwota;
                        wyswietl = temp.ImieInazwisko + ", saldo: " + temp.Saldo;
                        return wyswietl;
                    }
                    temp = temp.Next;
                }
                wyswietl = $"Przedszkolak'{imieInazwisko}' nie został znaleziony";
                return wyswietl;
            }
            return wyswietl;
        }

        private void wpisywanieDodaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void wpisywanieUsun_TextChanged(object sender, EventArgs e)
        {

        }

        private void wpisywanieWyszukaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void wpisywanieZmien_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
