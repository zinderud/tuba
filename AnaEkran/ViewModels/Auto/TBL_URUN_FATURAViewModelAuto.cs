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
	public partial class TBL_URUN_FATURAViewModel  : ViewModelDetailBase< TBL_URUN_FATURAViewModel,TBL_URUN_FATURA_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_URUN_FATURAViewModel () { }
TBL_URUN_FATURA_MODEL model=new TBL_URUN_FATURA_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_URUN_FATURAViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_URUN_FATURA  tablosu modeli
        /// </summary>
     
        private TBL_URUN_FATURA_MODEL _Propurun_fatura;

        public TBL_URUN_FATURA_MODEL Propurun_fatura
        {
            get { return _Propurun_fatura; }
            set { _Propurun_fatura = value;
                NotifyPropertyChanged(m=>m.Propurun_fatura);
                } 
        }
		 /// <summary>
        ///TBL_URUN_FATURA  tablosu Secilen
        /// </summary>
     
        private TBL_URUN_FATURA_MODEL _Propurun_faturaSecilen;

        public TBL_URUN_FATURA_MODEL Propurun_faturaSecilen
        {
            get { return _Propurun_faturaSecilen; }
            set { _Propurun_faturaSecilen = value;
                NotifyPropertyChanged(m=>m.Propurun_faturaSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_URUN_FATURA  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_FATURA_MODEL> _Propurun_faturaListe;

        public ObservableCollection<TBL_URUN_FATURA_MODEL> Propurun_faturaListe
        {
            get { return _Propurun_faturaListe; }
            set { _Propurun_faturaListe = value; 
                NotifyPropertyChanged(m=>m.Propurun_faturaListe);
                }
        }
         /// <summary>
        ///TBL_URUN_FATURA  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_FATURA_MODEL> _Propurun_faturaListeSecilen;

        public ObservableCollection<TBL_URUN_FATURA_MODEL> Propurun_faturaListeSecilen
        {
            get { return _Propurun_faturaListeSecilen; }
            set { _Propurun_faturaListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propurun_faturaListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_URUN_FATURA_MODEL model1 = new TBL_URUN_FATURA_MODEL();
              //  model1 = Propurun_faturaSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_URUN_FATURA_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_URUN_FATURAMesaj>(new EkleTBL_URUN_FATURAMesaj() { MesajTBL_URUN_FATURA= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_URUN_FATURAMesaj>(new EkleTBL_URUN_FATURAMesaj() { MesajTBL_URUN_FATURA= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_FATURAMesaj>(new HataTBL_URUN_FATURAMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_URUN_FATURA_MODEL model1 = new TBL_URUN_FATURA_MODEL();
                model1 = Propurun_faturaSecilen;
                if (await serviceAgent.Sil__TBL_URUN_FATURA_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_URUN_FATURAMesaj>(new SilTBL_URUN_FATURAMesaj() { MesajTBL_URUN_FATURA= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_URUN_FATURAMesaj>(new SilTBL_URUN_FATURAMesaj() { MesajTBL_URUN_FATURA= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_URUN_FATURAMesaj>(new HataTBL_URUN_FATURAMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_FATURA_MODEL model1 = new TBL_URUN_FATURA_MODEL();
                model1 = Propurun_faturaSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_FATURA_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_URUN_FATURAMesaj>(new DegistirTBL_URUN_FATURAMesaj() { MesajTBL_URUN_FATURA= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_URUN_FATURAMesaj>(new DegistirTBL_URUN_FATURAMesaj() { MesajTBL_URUN_FATURA= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_FATURAMesaj>(new HataTBL_URUN_FATURAMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propurun_faturaListe = await serviceAgent.Listele__TBL_URUN_FATURA_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_FATURAMesaj>(new HataTBL_URUN_FATURAMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propurun_fatura = await serviceAgent.Bul_TBL_URUN_FATURA_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_FATURAMesaj>(new HataTBL_URUN_FATURAMesaj() { Hatamesaji = ex.ToString()});


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
