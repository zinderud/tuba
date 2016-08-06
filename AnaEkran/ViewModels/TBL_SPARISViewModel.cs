//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using AnaEkran.Annotations;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using AnaEkran.Static;
using AnaEkran.Views.Raporlar;
using AnaEkran.Views.Raporlar.Siparis;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
    public partial class TBL_SPARISViewModel : ViewModelDetailBase<TBL_SPARISViewModel, TBL_SPARIS_MODEL>
    {


        public void Baslangic()
        {
            TBL_KDVListesi();
            TBL_SIRKETListesi();
            TBL_SPARIS_TURUListesi();
            TBL_PARA_TIPIListesi();
            TBL_KASAListesi();
            TBL_URUNListesi();
            TBL_DEPOListesi();
            TBL_PERSONELListesi();
            TBL_ODEME_TIPIListesi();

            UrunSparisListele();
            UrunSparisListesiModelListele();
        }

        #region TBL_SIRKET

        private ObservableCollection<TBL_SIRKET_MODEL> _TBL_SIRKETlistesiCollection;

        public ObservableCollection<TBL_SIRKET_MODEL> PropTBL_SIRKETlistesiCollection
        {
            get { return _TBL_SIRKETlistesiCollection; }
            set
            {
                _TBL_SIRKETlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_SIRKETlistesiCollection);
            }
        }

        private TBL_SIRKET_MODEL _TBL_SIRKET_MODELModel;

        public TBL_SIRKET_MODEL SecilenTBL_SIRKET_MODEL
        {
            get { return _TBL_SIRKET_MODELModel; }
            set
            {
                _TBL_SIRKET_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_SIRKET_MODEL);
                this.Model.TBL_SIRKET_ID = SecilenTBL_SIRKET_MODEL.TBL_SIRKET_ID;
            }
        }

        public async void TBL_SIRKETListesi()
        {
            PropTBL_SIRKETlistesiCollection = await serviceAgent.Listele__TBL_SIRKET_MODEL();
        }

        #endregion

        #region TBL_SPARIS_TURU

        private ObservableCollection<TBL_SPARIS_TURU_MODEL> _TBL_SPARIS_TURUlistesiCollection;

        public ObservableCollection<TBL_SPARIS_TURU_MODEL> PropTBL_SPARIS_TURUlistesiCollection
        {
            get { return _TBL_SPARIS_TURUlistesiCollection; }
            set
            {
                _TBL_SPARIS_TURUlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_SPARIS_TURUlistesiCollection);
            }
        }

        private TBL_SPARIS_TURU_MODEL _TBL_SPARIS_TURU_MODELModel;

        public TBL_SPARIS_TURU_MODEL SecilenTBL_SPARIS_TURU_MODEL
        {
            get { return _TBL_SPARIS_TURU_MODELModel; }
            set
            {
                _TBL_SPARIS_TURU_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_SPARIS_TURU_MODEL);
                this.Model.TBL_SPARIS_TURU_ID = SecilenTBL_SPARIS_TURU_MODEL.TBL_SPARIS_TURU_ID;
            }
        }

        public async void TBL_SPARIS_TURUListesi()
        {
            PropTBL_SPARIS_TURUlistesiCollection = await serviceAgent.Listele__TBL_SPARIS_TURU_MODEL();
        }

        #endregion

        #region TBL_PARA_TIPI

        private ObservableCollection<TBL_PARA_TIPI_MODEL> _TBL_PARA_TIPIlistesiCollection;

        public ObservableCollection<TBL_PARA_TIPI_MODEL> PropTBL_PARA_TIPIlistesiCollection
        {
            get { return _TBL_PARA_TIPIlistesiCollection; }
            set
            {
                _TBL_PARA_TIPIlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_PARA_TIPIlistesiCollection);
            }
        }

        private TBL_PARA_TIPI_MODEL _TBL_PARA_TIPI_MODELModel;

        public TBL_PARA_TIPI_MODEL SecilenTBL_PARA_TIPI_MODEL
        {
            get { return _TBL_PARA_TIPI_MODELModel; }
            set
            {
                _TBL_PARA_TIPI_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_PARA_TIPI_MODEL);
                this.Model.TBL_PARA_TIPI_ID = SecilenTBL_PARA_TIPI_MODEL.TBL_PARA_TIPI_ID;
            }
        }

        public async void TBL_PARA_TIPIListesi()
        {
            PropTBL_PARA_TIPIlistesiCollection = await serviceAgent.Listele__TBL_PARA_TIPI_MODEL();
        }

        #endregion

        #region TBL_ODEME_TIPI

        private ObservableCollection<TBL_ODEME_TIPI_MODEL> _TBL_ODEME_TIPIlistesiCollection;

        public ObservableCollection<TBL_ODEME_TIPI_MODEL> PropTBL_ODEME_TIPIlistesiCollection
        {
            get { return _TBL_ODEME_TIPIlistesiCollection; }
            set
            {
                _TBL_ODEME_TIPIlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_ODEME_TIPIlistesiCollection);
            }
        }

        private TBL_ODEME_TIPI_MODEL _TBL_ODEME_TIPI_MODELModel;

        public TBL_ODEME_TIPI_MODEL SecilenTBL_ODEME_TIPI_MODEL
        {
            get { return _TBL_ODEME_TIPI_MODELModel; }
            set
            {
                _TBL_ODEME_TIPI_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_ODEME_TIPI_MODEL);
                this.Model.TBL_ODEME_TIPI_ID = SecilenTBL_ODEME_TIPI_MODEL.TBL_ODEME_TIPI_ID;
            }
        }

        public async void TBL_ODEME_TIPIListesi()
        {
            PropTBL_ODEME_TIPIlistesiCollection = await serviceAgent.Listele__TBL_ODEME_TIPI_MODEL();
        }

        #endregion

        #region TBL_KASA

        private ObservableCollection<TBL_KASA_MODEL> _TBL_KASAlistesiCollection;

        public ObservableCollection<TBL_KASA_MODEL> PropTBL_KASAlistesiCollection
        {
            get { return _TBL_KASAlistesiCollection; }
            set
            {
                _TBL_KASAlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_KASAlistesiCollection);
            }
        }

        private TBL_KASA_MODEL _TBL_KASA_MODELModel;

        public TBL_KASA_MODEL SecilenTBL_KASA_MODEL
        {
            get { return _TBL_KASA_MODELModel; }
            set
            {
                _TBL_KASA_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_KASA_MODEL);
                this.Model.TBL_KASA_ID = SecilenTBL_KASA_MODEL.TBL_KASA_ID;
            }
        }

        public async void TBL_KASAListesi()
        {
            PropTBL_KASAlistesiCollection = await serviceAgent.Listele__TBL_KASA_MODEL();
        }

        #endregion

        #region TBL_URUN

        private ObservableCollection<TBL_URUN_MODEL> _TBL_URUNlistesiCollection;

        public ObservableCollection<TBL_URUN_MODEL> PropTBL_URUNlistesiCollection
        {
            get { return _TBL_URUNlistesiCollection; }
            set
            {
                _TBL_URUNlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_URUNlistesiCollection);
            }
        }

        private TBL_URUN_MODEL _TBL_URUN_MODELModel;

        public TBL_URUN_MODEL SecilenTBL_URUN_MODEL
        {
            get { return _TBL_URUN_MODELModel; }
            set
            {
                _TBL_URUN_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_URUN_MODEL);
                //TODO DÜZENLE// this.Model.TBL_URUN_ID = SecilenTBL_URUN_MODEL.TBL_URUN_ID;
            }
        }



        public async void TBL_URUNListesi()
        {
            PropTBL_URUNlistesiCollection = await serviceAgent.Listele__TBL_URUN_MODEL();


        }

        #endregion

        #region TBL_DEPO

        private ObservableCollection<TBL_DEPO_MODEL> _TBL_DEPOlistesiCollection;

        public ObservableCollection<TBL_DEPO_MODEL> PropTBL_DEPOlistesiCollection
        {
            get { return _TBL_DEPOlistesiCollection; }
            set
            {
                _TBL_DEPOlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_DEPOlistesiCollection);
            }
        }

        private TBL_DEPO_MODEL _TBL_DEPO_MODELModel;

        public TBL_DEPO_MODEL SecilenTBL_DEPO_MODEL
        {
            get { return _TBL_DEPO_MODELModel; }
            set
            {
                _TBL_DEPO_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_DEPO_MODEL);
                this.Model.TBL_DEPO_ID = SecilenTBL_DEPO_MODEL.TBL_DEPO_ID;
            }
        }

        public async void TBL_DEPOListesi()
        {
            PropTBL_DEPOlistesiCollection = await serviceAgent.Listele__TBL_DEPO_MODEL();
        }

        #endregion

        #region TBL_PERSONEL

        private ObservableCollection<TBL_PERSONEL_MODEL> _TBL_PERSONELlistesiCollection;

        public ObservableCollection<TBL_PERSONEL_MODEL> PropTBL_PERSONELlistesiCollection
        {
            get { return _TBL_PERSONELlistesiCollection; }
            set
            {
                _TBL_PERSONELlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_PERSONELlistesiCollection);
            }
        }

        private TBL_PERSONEL_MODEL _TBL_PERSONEL_MODELModel;

        public TBL_PERSONEL_MODEL SecilenTBL_PERSONEL_MODEL
        {
            get { return _TBL_PERSONEL_MODELModel; }
            set
            {
                _TBL_PERSONEL_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_PERSONEL_MODEL);
                this.Model.TBL_PERSONEL_ID = SecilenTBL_PERSONEL_MODEL.TBL_PERSONEL_ID;
            }
        }

        public async void TBL_PERSONELListesi()
        {
            PropTBL_PERSONELlistesiCollection = await serviceAgent.Listele__TBL_PERSONEL_MODEL();
        }

        #endregion

        #region TBL_KDV

        private ObservableCollection<TBL_KDV_MODEL> _TBL_KDVlistesiCollection;

        public ObservableCollection<TBL_KDV_MODEL> PropTBL_KDVlistesiCollection
        {
            get { return _TBL_KDVlistesiCollection; }
            set
            {
                _TBL_KDVlistesiCollection = value;
                NotifyPropertyChanged(m => m.PropTBL_KDVlistesiCollection);
            }
        }

        private TBL_KDV_MODEL _TBL_KDV_MODELModel;

        public TBL_KDV_MODEL SecilenTBL_KDV_MODEL
        {
            get { return _TBL_KDV_MODELModel; }
            set
            {
                _TBL_KDV_MODELModel = value;
                NotifyPropertyChanged(m => m.SecilenTBL_KDV_MODEL);
                //this.Model.TBL_KDV_ID = SecilenTBL_KDV_MODEL.TBL_KDV_ID;
            }
        }

        public async void TBL_KDVListesi()
        {
            PropTBL_KDVlistesiCollection = await serviceAgent.Listele__TBL_KDV_MODEL();
        }

        #endregion

        #region spariþ ürün iliþkisi



        private ObservableCollection<UrunSparisListesiModel> _propUrunSparisListesiModels;

        public ObservableCollection<UrunSparisListesiModel> PropUrunSparisListesiModelsObservableCollection
        {
            get { return _propUrunSparisListesiModels; }
            set
            {
                _propUrunSparisListesiModels = value;
                NotifyPropertyChanged(m => m.PropUrunSparisListesiModelsObservableCollection);
            }
        }





        private UrunSparisListesiModel _onaylýUrunSparisListesiModel;

        public UrunSparisListesiModel OnayliSparisListesiModel
        {
            get { return _onaylýUrunSparisListesiModel; }
            set
            {
                _onaylýUrunSparisListesiModel = value;
                NotifyPropertyChanged(m => m.OnayliSparisListesiModel);
            }
        }

        private ObservableCollection<UrunSparisListesiModel> _propSipariseHazirUrunSparisListesiModels;

        public ObservableCollection<UrunSparisListesiModel> PropSipariseHazirUrunSparisListesiModels
        {
            get { return _propSipariseHazirUrunSparisListesiModels; }
            set
            {
                _propSipariseHazirUrunSparisListesiModels = value;
                Model.YEDEK = SiparisinToplamTutari().ToString();
                NotifyPropertyChanged(m => m.PropSipariseHazirUrunSparisListesiModels);
            }
        }

        private UrunSparisListesiModel _prophazirUrunSparisListesiModel;

        public UrunSparisListesiModel ProphazirUrunSparisListesiModel
        {
            get { return _prophazirUrunSparisListesiModel; }
            set
            {
                _prophazirUrunSparisListesiModel = value;
                NotifyPropertyChanged(m => m.ProphazirUrunSparisListesiModel);
                try
                {
                    SecilenDegisikligiKoleksiyonaUygula();
                    //ProphazirUrunSparisListesiModel.ToplamFiyat = toplamfiyatBelirle(ProphazirUrunSparisListesiModel.URUN_SATIS_FIYATI, ProphazirUrunSparisListesiModel.Adet, ProphazirUrunSparisListesiModel.TBL_KDV_ID);
                }
                catch (Exception)
                {

                }

            }
        }

        public void SecilenDegisikligiKoleksiyonaUygula()
        {
            try
            {
                foreach (
                    var item in
                        PropSipariseHazirUrunSparisListesiModels.Where(
                            k => k.TBL_URUN_ID == ProphazirUrunSparisListesiModel.TBL_URUN_ID))
                {
                    int kdv = Kdvgoster(ProphazirUrunSparisListesiModel.TBL_KDV_ID);
                    item.ToplamFiyat =
                        toplamfiyatBelirle(ProphazirUrunSparisListesiModel.URUN_SATIS_FIYATI,
                            ProphazirUrunSparisListesiModel.Adet, kdv);
                    item.Adet = ProphazirUrunSparisListesiModel.Adet;
                    item.URUN_SATIS_FIYATI = ProphazirUrunSparisListesiModel.URUN_SATIS_FIYATI;
                    item.TBL_KDV_ID = ProphazirUrunSparisListesiModel.TBL_KDV_ID;
                }
            }
            catch (Exception)
            {

            }
            Model.YEDEK = SiparisinToplamTutari().ToString();

        }

        public string toplamfiyatBelirle(string satisfiyati, string adeti, int? kdvs)
        {

            double satisFiyati = Convert.ToDouble(satisfiyati);
            double adet = Convert.ToDouble(adeti);
            double kdv = Convert.ToDouble(kdvs);
            double toplam = satisFiyati*adet*
                            (100 + kdv)/100;
            return toplam.ToString();
        }

        private ObservableCollection<UrunSparisListesiModel> madelii =
            new ObservableCollection<UrunSparisListesiModel>();

        public void EklemeHazirUrunSiparisListesiniyenile()
        {
            PropSipariseHazirUrunSparisListesiModels = madelii;
        }

        public void EklemeHazirUrunSiparisListesineAtar()
        {

            try
            {
                if (OnayliSparisListesiModel.TBL_URUN_ID != null)
                {
                    int kdv = Kdvgoster(OnayliSparisListesiModel.TBL_KDV_ID);
                    OnayliSparisListesiModel.ToplamFiyat = toplamfiyatBelirle(
                        OnayliSparisListesiModel.URUN_SATIS_FIYATI,
                        OnayliSparisListesiModel.Adet, kdv);
                    madelii.Add(OnayliSparisListesiModel);
                    PropUrunSparisListesiModelsObservableCollection.Remove(OnayliSparisListesiModel);
                    PropSipariseHazirUrunSparisListesiModels = madelii;
                }

            }
            catch (Exception)
            {


            }

        }

        public int Kdvgoster(int? kdv)
        {
            try
            {
                var dene = (from k in PropTBL_KDVlistesiCollection where k.TBL_KDV_ID == kdv select k).FirstOrDefault();
                return Convert.ToInt32(dene.KDV_YUZDESI);
            }
            catch (Exception)
            {


            }
            return 0;


        }


        public async void UrunSparisListesiModelListele()
        {
            ObservableCollection<TBL_URUN_MODEL> modsTblUrunModels = new ObservableCollection<TBL_URUN_MODEL>();
            ObservableCollection<UrunSparisListesiModel> modeluruUrunSparisListesiModels =
                new ObservableCollection<UrunSparisListesiModel>();
            modsTblUrunModels = await serviceAgent.Listele__TBL_URUN_MODEL();
            foreach (var k in modsTblUrunModels)
            {
                int kdv = Kdvgoster(k.TBL_KDV_ID);
                UrunSparisListesiModel _urunSparisListesiModel;
                _urunSparisListesiModel = new UrunSparisListesiModel();
                _urunSparisListesiModel.TBL_URUN_ID = k.TBL_URUN_ID;
                _urunSparisListesiModel.URUN_ADI = k.URUN_ADI;
                _urunSparisListesiModel.URUN_KODU = k.URUN_KODU;
                _urunSparisListesiModel.URUN_SATIS_FIYATI = k.URUN_SATIS_FIYATI;
                _urunSparisListesiModel.TBL_KDV_ID = k.TBL_KDV_ID;
                _urunSparisListesiModel.ToplamFiyat = toplamfiyatBelirle(k.URUN_SATIS_FIYATI, "1", kdv);

                modeluruUrunSparisListesiModels.Add(_urunSparisListesiModel);
            }
            PropUrunSparisListesiModelsObservableCollection = modeluruUrunSparisListesiModels;
        }


        private string _barkod;

        public string Barkod
        {
            get { return _barkod; }
            set
            {
                _barkod = value;
                NotifyPropertyChanged(m => m.Barkod);
            }
        }

        public void BarkoduIleUrunEkle()
        {
            if (PropUrunSparisListesiModelsObservableCollection != null)
            {
                try
                {
                    foreach (var k in PropUrunSparisListesiModelsObservableCollection)
                    {
                        if (k.URUN_KODU == Barkod)
                        {

                            madelii.Add(k);

                            PropUrunSparisListesiModelsObservableCollection.Remove(k);

                            PropSipariseHazirUrunSparisListesiModels = madelii;

                        }

                    }
                    Model.YEDEK = SiparisinToplamTutari().ToString();
                }
                catch (Exception)
                {

                    //MessageBox.Show("urun bulunamadý yada ürünü tekrar eklemeye çalýþýyor olabilirsiniz!");
                }


            }

        }



        public double SiparisinToplamTutari()
        {

            return PropSipariseHazirUrunSparisListesiModels.Sum(k => Convert.ToDouble(k.ToplamFiyat));


        }

        public async void SiparisUrunTablosunaKayit()
        {

            try
            {
                //db.Users.OrderByDescending(u => u.UserId).FirstOrDefault()
                //var id = await serviceAgent.Listele__TBL_SPARIS_MODEL();

                //int sayii = PropsparýsListe.OrderByDescending(u => u.TBL_SPARIS_ID).FirstOrDefault().TBL_SPARIS_ID;
                var dere = await serviceAgent.Listele__TBL_SPARIS_MODEL();
                int sayii = dere.OrderByDescending(u => u.TBL_SPARIS_ID).First().TBL_SPARIS_ID;


                foreach (var k in PropSipariseHazirUrunSparisListesiModels)
                {
                    TBL_URUN_SPARIS_MODEL model111 = new TBL_URUN_SPARIS_MODEL();

                    model111.TBL_SIPARIS_ID = sayii;
                    model111.TBL_URUN_ID = k.TBL_URUN_ID;
                    model111.URUN_SIPARIS_MIKTAR = k.Adet;
                    bool sonuc = await serviceAgent.Ekle__TBL_URUN_SPARIS_MODEL(model111);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("SiparisUrun Tablosuna Kayit yapýlamadý");
            }
            
        }

        public async Task<bool> KasaTablosunaKayit()
        {
            bool sonuc = false;


            try
            {
                if (this.Model.TBL_SPARIS_TURU_ID == 1)
                {
                    TBL_KASA_BAKIYE_MODEL kasabakiye = new TBL_KASA_BAKIYE_MODEL();
                    kasabakiye.TBL_KASA_ID = this.Model.TBL_KASA_ID;
                    kasabakiye.TARIH = this.model.SPARIS_TARIH;
                    kasabakiye.TBL_PARA_TIPI_ID = model.TBL_PARA_TIPI_ID;
                    kasabakiye.TUTAR = "-" + this.Model.YEDEK;
                    kasabakiye.ACIKLAMA = "ALIÞ SÝPARÝÞÝ";

                    sonuc = await serviceAgent.Ekle__TBL_KASA_BAKIYE_MODEL(kasabakiye);
                 }
                if (this.Model.TBL_SPARIS_TURU_ID == 2)
                {
                    TBL_KASA_BAKIYE_MODEL kasabakiye = new TBL_KASA_BAKIYE_MODEL();
                    kasabakiye.TBL_KASA_ID = this.Model.TBL_KASA_ID;
                    kasabakiye.TARIH = this.model.SPARIS_TARIH;
                    kasabakiye.TBL_PARA_TIPI_ID = model.TBL_PARA_TIPI_ID;
                    kasabakiye.TUTAR = this.Model.YEDEK;
                    kasabakiye.ACIKLAMA = "SATIÞ SÝPARÝÞÝ";
                    sonuc = await serviceAgent.Ekle__TBL_KASA_BAKIYE_MODEL(kasabakiye);
                 }
                //else
                //{
                //    sonuc = false;
                //    MessageBox.Show("sipariþ türü girilmedi");

                //}
            }
            catch (Exception)
            {
                sonuc = false;
                MessageBox.Show("kasatoblosuna kayýt yapýlamadý");
            }



            return sonuc;


        }

        public async Task<bool> DepoTablosunaKayit()
        {

            bool sonucu = false;
            try
            {
                var sirketadi =
                    PropTBL_SIRKETlistesiCollection.Where(k => k.TBL_SIRKET_ID == this.Model.TBL_SIRKET_ID)
                        .FirstOrDefault();
                foreach (var k in PropSipariseHazirUrunSparisListesiModels)
                {
                    TBL_DEPO_ISLEM_MODEL depoIslem = new TBL_DEPO_ISLEM_MODEL();

                    depoIslem.TBL_DEPO_ID = this.Model.TBL_DEPO_ID;
                    depoIslem.TBL_URUN_ID = k.TBL_URUN_ID;
                    depoIslem.URUN_MIKTAR = k.Adet;
                    depoIslem.DEPO_ISLEM_ADI = " verilecek ürün";
                    depoIslem.ACIKLAMA = sirketadi.SIRKET_ADI + " 'in " + DateTime.Now.ToLongDateString() +
                                         " tarihli iþlemi";
                    depoIslem.DEPO_ONAY = "HAYIR";
                    bool sonuc = await serviceAgent.Ekle__TBL_DEPO_ISLEM_MODEL(depoIslem);
 
                }
                sonucu = true;
            }
            catch (Exception)
            {

                sonucu = false;
            }



            return sonucu;


        }

        public async Task<bool> OdemeTablosunaKayit()
        {
            bool sonuc = false;
            var sirketadi =
                PropTBL_SIRKETlistesiCollection.Where(k => k.TBL_SIRKET_ID == this.Model.TBL_SIRKET_ID).FirstOrDefault();

            try
            {
                if (this.Model.TBL_SPARIS_TURU_ID == 1)
                {
                    TBL_ODEME_MODEL odemeModel = new TBL_ODEME_MODEL();
                    odemeModel.TBL_ODEME_TIPI_ID = this.Model.TBL_ODEME_TIPI_ID;
                    odemeModel.TBL_KASA_ID = this.Model.TBL_KASA_ID;

                    odemeModel.ODEME_KAYIT_TARIHI = this.Model.SPARIS_TARIH;
                    odemeModel.TBL_PARA_TIPI_ID = Model.TBL_PARA_TIPI_ID;
                    odemeModel.TUTAR = "-" + this.Model.YEDEK;
                    odemeModel.TBL_SIRKET_ID = this.Model.TBL_SIRKET_ID;
                    odemeModel.BELGE_NO = this.Model.SPARIS_FATURA_SERI_NO;
                    odemeModel.TBL_ODEME_TURU_ID = 2;
                    
                    sonuc = await serviceAgent.Ekle__TBL_ODEME_MODEL(odemeModel);

                }
                if (this.Model.TBL_SPARIS_TURU_ID == 2)
                {
                    TBL_ODEME_MODEL odemeModel = new TBL_ODEME_MODEL();
                    odemeModel.TBL_ODEME_TIPI_ID = this.Model.TBL_ODEME_TIPI_ID;
                    odemeModel.TBL_KASA_ID = this.Model.TBL_KASA_ID;

                    odemeModel.ODEME_KAYIT_TARIHI = this.Model.SPARIS_TARIH;
                    odemeModel.TBL_PARA_TIPI_ID = Model.TBL_PARA_TIPI_ID;
                    odemeModel.TUTAR =  this.Model.YEDEK;
                    odemeModel.TBL_SIRKET_ID = this.Model.TBL_SIRKET_ID;
                    odemeModel.BELGE_NO = this.Model.SPARIS_FATURA_SERI_NO;
                    odemeModel.TBL_ODEME_TURU_ID = 1;
                    //TODO ODEMETURÝD DÜZENLENMESÝ GEREK
                    sonuc = await serviceAgent.Ekle__TBL_ODEME_MODEL(odemeModel);

                }


                //else
                //{
                //    sonuc = false;
                //    MessageBox.Show("sipariþ türü girilmedi");

                //}
            }
            catch (Exception)
            {
                sonuc = false;
                MessageBox.Show("Odeme toblosuna kayýt yapýlamadý");
            }



            return sonuc;
        }

        public async Task<bool> UrunStokTablosunaKayit()
        {
            bool sonucu = false;
            try
            {
                var sirketadi =
                    PropTBL_SIRKETlistesiCollection.Where(k => k.TBL_SIRKET_ID == this.Model.TBL_SIRKET_ID)
                        .FirstOrDefault();
                foreach (var k in PropSipariseHazirUrunSparisListesiModels)
                {
                    TBL_URUN_STOK_MODEL urunStokModel = new TBL_URUN_STOK_MODEL();

                    urunStokModel.TBL_DEPO_ID = this.Model.TBL_DEPO_ID;
                    urunStokModel.TBL_URUN_ID = k.TBL_URUN_ID;
                    urunStokModel.URUN_BIRIM_MIKTARI =Convert.ToInt32( "-"+k.Adet) ;
                    urunStokModel.ACIKLAMA = sirketadi.SIRKET_ADI + " 'in " + DateTime.Now.ToLongDateString() +
                                         " tarihli satýþ iþlemi";
                  
                    //depoIslem.ACIKLAMA = sirketadi.SIRKET_ADI + " 'in " + DateTime.Now.ToLongDateString() +
                    //                     " tarihli iþlemi";
                    //depoIslem.DEPO_ONAY = "HAYIR";
                    bool sonuc = await serviceAgent.Ekle__TBL_URUN_STOK_MODEL(urunStokModel);

                }
                sonucu = true;
            }
            catch (Exception)
            {

                sonucu = false;
            }



            return sonucu;
        }
     

    #endregion

        #region SpariþUrunListele

        /// <summary>
        ///TBL_URUN_SPARIS  tablosu Listesi modeli
        /// </summary>

        private ObservableCollection<TBL_URUN_SPARIS_MODEL> _Propurun_sparýsListe;

        public ObservableCollection<TBL_URUN_SPARIS_MODEL> Propurun_sparýsListe
        {
            get { return _Propurun_sparýsListe; }
            set
            {
                _Propurun_sparýsListe = value;
                NotifyPropertyChanged(m => m.Propurun_sparýsListe);
            }
        }
        private TBL_URUN_SPARIS_MODEL _Propurun_sparýsSecilen;

        public TBL_URUN_SPARIS_MODEL Propurun_sparýsSecilen
        {
            get { return _Propurun_sparýsSecilen; }
            set
            {
                _Propurun_sparýsSecilen = value;
                NotifyPropertyChanged(m => m.Propurun_sparýsSecilen);
            }
        }
        public async void UrunSparisListele()
        {
            try
            {
                Propurun_sparýsListe = await serviceAgent.Listele__TBL_URUN_SPARIS_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_SPARISMesaj>(new HataTBL_URUN_SPARISMesaj() { Hatamesaji = ex.ToString() });


            }

        }
        /// <summary>
        ///TBL_URUN_SPARIS  tablosu Listesi secilen modeli
        /// </summary>

        private ObservableCollection<TBL_URUN_SPARIS_MODEL> _Propurun_sparýsListeSecilen;

        public ObservableCollection<TBL_URUN_SPARIS_MODEL> Propurun_sparýsListeSecilen
        {
            get { return _Propurun_sparýsListeSecilen; }
            set
            {
                _Propurun_sparýsListeSecilen = value;
                NotifyPropertyChanged(m => m.Propurun_sparýsListeSecilen);
            }
        }


	    public void SecilenUrunSparisListesi(int siparisid)
	    {
	        Propurun_sparýsListeSecilen =
	            (from k in Propurun_sparýsListe where k.TBL_SIPARIS_ID == siparisid select k).ToObservableCollection();

	    }
        #endregion


        #region ToplamSipariþTutarHesapla

	    public void UrunBasinaTutar()
	    {
            //Model.YEDEK=Model.
	    }
        #endregion



        //OdemeTipiadi(k.TBL_ODEME_TIPI_ID),

        public String OdemeTipiadi(int? id)
        {
            try
            {
                return PropTBL_ODEME_TIPIlistesiCollection.Where(x => x.TBL_ODEME_TIPI_ID == id).FirstOrDefault().ODEME_TIPI_ADI;
            }
            catch (Exception)
            {


            }
            return null;
        }
        //Sirketadi(k.TBL_SIRKET_ID),
        public String Sirketadi(int? id)
        {
            try
            {
                return PropTBL_SIRKETlistesiCollection.Where(x => x.TBL_SIRKET_ID == id).FirstOrDefault().SIRKET_ADI;
            }
            catch (Exception)
            {


            }
            return null;
        }
        // pARAadi( k.TBL_PARA_TIPI_ID),
        public String pARAadi(int? id)
        {
            try
            {
                return PropTBL_PARA_TIPIlistesiCollection.Where(x => x.TBL_PARA_TIPI_ID == id).FirstOrDefault().PARA_TIPI_ADI;

            }
            catch (Exception)
            {


            }
            return null;
        }
        // Kasaadi(k.TBL_KASA_ID),
        public String Kasaadi(int? id)
        {
            try
            {
                return PropTBL_KASAlistesiCollection.Where(x => x.TBL_KASA_ID == id).FirstOrDefault().KASA_ADI;
            }
            catch (Exception)
            {


            }
            return null;
        }
        // Depoadi(Convert.ToInt32( k.DEPO_TRANSFER_NEREDEN))
        public String Depoadi(int? id)
        {
            try
            {
                return PropTBL_DEPOlistesiCollection.Where(x => x.TBL_DEPO_ID == id).FirstOrDefault().DEPO_ADI;
            }
            catch (Exception)
            {


            }
            return null;
        }
        // Personeladi(k.TBL_PERSONEL_ID) ,
        public String Personeladi(int? id)
        {
            try
            {
                return PropTBL_PERSONELlistesiCollection.Where(x => x.TBL_PERSONEL_ID == id).FirstOrDefault().PERSONEL_AD_SOYAD;
            }
            catch (Exception)
            {


            }
            return null;
        }

        //SiparisTuruadi(k.TBL_SPARIS_TURU_ID),
        public String SiparisTuruadi(int? id)
        {
            try
            {
                return PropTBL_SPARIS_TURUlistesiCollection.Where(x => x.TBL_SPARIS_TURU_ID == id).FirstOrDefault().SPARIS_TURU_ADI;
            }
            catch (Exception)
            {


            }
            return null;
        }
        public void RaporSiparisListesi()
        {
            try
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "BankaListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("SIRKET ADI", typeof(string));

                dataTable1.Columns.Add("SPARIS TURU", typeof(string));

                dataTable1.Columns.Add("TARIH", typeof(string));

                dataTable1.Columns.Add("VADE_TARIH", typeof(string));

                dataTable1.Columns.Add("FATURA_SERI_NO", typeof(string));

                dataTable1.Columns.Add("TPARA_TIPI", typeof(string));

                dataTable1.Columns.Add("ODEME_TIPI", typeof(string));

                dataTable1.Columns.Add("KASA", typeof(string));

                dataTable1.Columns.Add("DEPO", typeof(string));

                dataTable1.Columns.Add("PERSONEL", typeof(string));

                dataTable1.Columns.Add("TUTAR", typeof(string));
                foreach (var k in PropsparýsListe)
                {
                    dataTable1.Rows.Add(new Object[]
                    {

                        k.TBL_SPARIS_ID,

                       Sirketadi(k.TBL_SIRKET_ID),

                        SiparisTuruadi(k.TBL_SPARIS_TURU_ID),

                        k.SPARIS_TARIH,

                        k.SPARIS_VADE_TARIH,

                        k.SPARIS_FATURA_SERI_NO,

                        pARAadi( k.TBL_PARA_TIPI_ID),

                       OdemeTipiadi(k.TBL_ODEME_TIPI_ID),

                       Kasaadi(k.TBL_KASA_ID),

                        Depoadi(k.TBL_DEPO_ID),

                       Personeladi(k.TBL_PERSONEL_ID) ,

                        k.YEDEK,


                    });
                }
                RaporSiparisListesi report = new RaporSiparisListesi();
report.DataSource = dataSet1;
report.DataMember = dataTable1.TableName;
	 
//_tBL_SPARIS_ID
report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;

	 
//_tBL_SIRKET_ID
report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;

	 
//_tBL_SPARIS_TURU_ID
report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;

	 
//_sPARIS_TARIH
report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;

//_tBL_KASA_ID
report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[8].Caption);
report.xrLabel5.Text = dataTable1.Columns[8].ColumnName;	 
//_sPARIS_VADE_TARIH
//report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
//report.xrLabel5.Text = dataTable1.Columns[4].ColumnName;


//_tBL_DEPO_ID
report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[9].Caption);
report.xrLabel6.Text = dataTable1.Columns[9].ColumnName;
////_sPARIS_FATURA_SERI_NO
//report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
//report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;

//_yEDEK
report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[11].Caption);
report.xrLabel7.Text = dataTable1.Columns[11].ColumnName;
////_tBL_PARA_TIPI_ID
//report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
//report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;

	 
////_tBL_ODEME_TIPI_ID
//report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
//report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;

	 
 



	 
////_tBL_PERSONEL_ID
//report.xrTableCell11.DataBindings.Add("Text", null, dataTable1.Columns[10].Caption);
//report.xrLabel11.Text = dataTable1.Columns[10].ColumnName;


RaporSayfasi pencere = new RaporSayfasi();


pencere.Preview.Model = new XtraReportPreviewModel(report);
report.CreateDocument(true);



pencere.ShowDialog();

 
 //report.ShowPreviewDialog();


            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
        }
    }
}
