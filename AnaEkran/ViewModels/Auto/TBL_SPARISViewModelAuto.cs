//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_SPARISViewModel  : ViewModelDetailBase< TBL_SPARISViewModel,TBL_SPARIS_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_SPARISViewModel () { }
TBL_SPARIS_MODEL model=new TBL_SPARIS_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_SPARISViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_SPARIS  tablosu modeli
        /// </summary>
     
        private TBL_SPARIS_MODEL _Propsparıs;

        public TBL_SPARIS_MODEL Propsparıs
        {
            get { return _Propsparıs; }
            set { _Propsparıs = value;
                NotifyPropertyChanged(m=>m.Propsparıs);
                } 
        }
		 /// <summary>
        ///TBL_SPARIS  tablosu Secilen
        /// </summary>
     
        private TBL_SPARIS_MODEL _PropsparısSecilen;

        public TBL_SPARIS_MODEL PropsparısSecilen
        {
            get { return _PropsparısSecilen; }
            set { _PropsparısSecilen = value;
                NotifyPropertyChanged(m=>m.PropsparısSecilen);
                try
                {
                    SecilenUrunSparisListesi(PropsparısSecilen.TBL_SPARIS_ID);
                }
                catch (Exception)
                {
                    
                }
               
            } 
        }
        
		 /// <summary>
        ///TBL_SPARIS  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_SPARIS_MODEL> _PropsparısListe;

        public ObservableCollection<TBL_SPARIS_MODEL> PropsparısListe
        {
            get { return _PropsparısListe; }
            set { _PropsparısListe = value; 
                NotifyPropertyChanged(m=>m.PropsparısListe);
                }
        }
         /// <summary>
        ///TBL_SPARIS  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_SPARIS_MODEL> _PropsparısListeSecilen;

        public ObservableCollection<TBL_SPARIS_MODEL> PropsparısListeSecilen
        {
            get { return _PropsparısListeSecilen; }
            set { _PropsparısListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropsparısListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_SPARIS_MODEL model1 = new TBL_SPARIS_MODEL();
              //  model1 = PropsparısSecilen;

                //todo siparişin toplam miktarı
               
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_SPARIS_MODEL(model1))
                {
                    SiparisUrunTablosunaKayit();
                   await KasaTablosunaKayit();
                    await DepoTablosunaKayit();
                  await  OdemeTablosunaKayit();
                 await  UrunStokTablosunaKayit();
                    UrunSparisListele();
                  

                     
                       Listele();
                    Messenger.Default.Send<EkleTBL_SPARISMesaj>(new EkleTBL_SPARISMesaj() { MesajTBL_SPARIS= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_SPARISMesaj>(new EkleTBL_SPARISMesaj() { MesajTBL_SPARIS= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SPARISMesaj>(new HataTBL_SPARISMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_SPARIS_MODEL model1 = new TBL_SPARIS_MODEL();
                model1 = PropsparısSecilen;
                if (await serviceAgent.Sil__TBL_SPARIS_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_SPARISMesaj>(new SilTBL_SPARISMesaj() { MesajTBL_SPARIS= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_SPARISMesaj>(new SilTBL_SPARISMesaj() { MesajTBL_SPARIS= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_SPARISMesaj>(new HataTBL_SPARISMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_SPARIS_MODEL model1 = new TBL_SPARIS_MODEL();
                model1 = PropsparısSecilen;
            if (await serviceAgent.Degistir__TBL_SPARIS_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_SPARISMesaj>(new DegistirTBL_SPARISMesaj() { MesajTBL_SPARIS= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_SPARISMesaj>(new DegistirTBL_SPARISMesaj() { MesajTBL_SPARIS= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SPARISMesaj>(new HataTBL_SPARISMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropsparısListe = await serviceAgent.Listele__TBL_SPARIS_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SPARISMesaj>(new HataTBL_SPARISMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propsparıs = await serviceAgent.Bul_TBL_SPARIS_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SPARISMesaj>(new HataTBL_SPARISMesaj() { Hatamesaji = ex.ToString()});


             }
        }
        
        #endregion
		#region komut
	 public ICommand EkleCommand
        {
            get
            {
                return new DelegateCommand(Ekle);
            }
        }
		 public ICommand SiCommand
        {
            get
            {
                return new DelegateCommand(Sil);
            }
        }
		 public ICommand DegistirCommand
        {
            get
            {
                return new DelegateCommand(Degistir);
            }
        }
		 public ICommand ListeleCommand
        {
            get
            {
                return new DelegateCommand(Listele);
            }
        }
		 public ICommand BulCommand
        {
            get
            {
                return new DelegateCommand<int>(Bul);
            }
        }
	   #endregion

        
         
	}
}
