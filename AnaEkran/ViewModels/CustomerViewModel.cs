using System;
using System.Windows;
using System.Windows.Input;
using System.Threading;
using System.Collections.ObjectModel;

// Toolkit namespace
using AnaEkran.Models;
using SimpleMvvmToolkit;

// Toolkit extension methods
using SimpleMvvmToolkit.ModelExtensions;
using AnaEkran.Provider;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AnaEkran
{
    /// <summary>
    /// This class extends ViewModelDetailBase which implements IEditableDataObject.
    /// <para>
    /// Specify type being edited <strong>DetailType</strong> as the second type argument
    /// and as a parameter to the seccond ctor.
    /// </para>
    /// <para>
    /// Use the <strong>mvvmprop</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// </summary>
    public class CustomerViewModel : ViewModelBase<CustomerViewModel>
    {
        #region Initialization and Cleanup

        // Add a member for ICustomerServiceAgent
        private IProvider serviceAgent;

        // Default ctor
        public CustomerViewModel() { }

        // Ctor that accepts ICustomerServiceAgent
        public CustomerViewModel(IProvider serviceAgent)
        {
            this.serviceAgent = serviceAgent;
        }

        #endregion

        #region Notifications

        // TODO: Add events to notify the view or obtain data from the view
        public event EventHandler<NotificationEventArgs<Exception>> ErrorNotice;

        #endregion

        #region Properties
        /// <summary>
        ///TBL_URUN  tablosu modeli
        /// </summary>

        private TBL_URUN_MODEL _tbl_urun;

        public TBL_URUN_MODEL tbl_urun
        {
            get { return _tbl_urun; }
            set
            {
                _tbl_urun = value;
                NotifyPropertyChanged(m => m.tbl_urun);
            }
        }
        /// <summary>
        ///TBL_URUN  tablosu Secilen
        /// </summary>

        private TBL_URUN_MODEL _tbl_urunSecilen;

        public TBL_URUN_MODEL tbl_urunSecilen
        {
            get { return _tbl_urunSecilen; }
            set
            {
                _tbl_urunSecilen = value;
                NotifyPropertyChanged(m => m.tbl_urunSecilen);
            }
        }

        /// <summary>
        ///TBL_URUN  tablosu Listesi modeli
        /// </summary>

        private ObservableCollection<TBL_URUN_MODEL> _tbl_urunListe;

        public ObservableCollection<TBL_URUN_MODEL> tbl_urunListe
        {
            get { return _tbl_urunListe; }
            set
            {
                _tbl_urunListe = value;
                NotifyPropertyChanged(m => m.tbl_urunListe);
            }
        }
        /// <summary>
        ///TBL_URUN  tablosu Listesi secilen modeli
        /// </summary>

        private ObservableCollection<TBL_URUN_MODEL> _tbl_urunListeSecilen;

        public ObservableCollection<TBL_URUN_MODEL> tbl_urunListeSecilen
        {
            get { return _tbl_urunListeSecilen; }
            set
            {
                _tbl_urunListeSecilen = value;
                NotifyPropertyChanged(m => m.tbl_urunListeSecilen);
            }
        }



        #endregion

        #region Methods

      

        public async void ekle()
        {
            try
            {
                TBL_URUN_MODEL model = new TBL_URUN_MODEL();
                model = tbl_urunSecilen;
                if (await serviceAgent.Ekle__TBL_URUN_MODEL(model))
                {
                    // eklendi
                }
                else
                {
                    //hata
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Hata olustu {0}"+exception.Data.ToString());  
                
            }
            
        }
        public async void sil()
        {
            try
            {
                TBL_URUN_MODEL model = new TBL_URUN_MODEL();
                model = tbl_urunSecilen;
                if (await serviceAgent.Sil__TBL_URUN_MODEL(model))
                {
                    // silindi
                }
                else
                {
                    //hata
                }
            }
            catch (Exception exception)
            {
                
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_MODEL model = new TBL_URUN_MODEL();
                model = tbl_urunSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_MODEL(model))
            {
                // değiştirildi
            }
            else
            {
                //hata
            }
            }
             catch (Exception exception)
             {


             }
        }
        public async void Listele()
        {
            try
            {
                tbl_urunListe = await serviceAgent.Listele__TBL_URUN_MODEL();
            }
            catch (Exception ex)
            {
                
              
            }
           
        }
        public async void bul(int id)
        {
             try
            {
              tbl_urun = await serviceAgent.Bul_TBL_URUN_MODEL(id);
            }
             catch (Exception ex)
             {


             }
        }
        
        #endregion

        #region Commands

        public ICommand NewCustomerCommand
        {
            get
            {
                return new DelegateCommand(NewCustomer);
            }
        }

        private void NewCustomer()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Completion Callbacks

        // TODO: Optionally add callback methods for async calls to the service agent

        #endregion

        #region Helpers

        // Helper method to notify View of an error
        private void NotifyError(string message, Exception error)
        {
            // Notify view of an error
            Notify(ErrorNotice, new NotificationEventArgs<Exception>(message, error));
        }

        #endregion
    }
}