using Guignolee.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guignolee.ViewModels
{
    public class DonViewModel : ValidableViewModel
    {
        private readonly Don _don;

        public DonViewModel(Don don)
        {
            _don = don;
            _errors.Add("Donateur", new ObservableCollection<ValidationResult>());
            _errors.Add("Contenu", new ObservableCollection<ValidationResult>());
            _errors.Add("Quantite", new ObservableCollection<ValidationResult>());
        }

        public int Id => _don.Id;


        [Required(ErrorMessage = "Le donateur est obligatoire.")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Le donateur doit contenir de 2 à 50 caractères.")]
        public string Donateur
        {
            get { return _don.Donateur; }
            set
            {
                // TODO: appliquer les validations && Validate(value)
                if (_don.Donateur != value)
                {
                    _don.Donateur = value;
                    // TODO: RaisePropertyChanged pour notifier que la propriété Donateur a changé.
                }
            }
        }
        [Required(ErrorMessage = "Le contenu est obligatoire.")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Le contenu doit contenir de 2 à 50 caractères.")]
        public string Contenu
        {
            get { return _don.Contenu; }
            set
            {
                if (_don.Contenu != value )
                {
                    _don.Contenu = value;
                }
            }
        }
        [Required(ErrorMessage = "La quantité est obligatoire.")]
        [StringLength(100, MinimumLength = 1,
            ErrorMessage = "La quantité doit contenir de 1 à 100 articles.")]
        public int Quantite
        {
            get { return _don.Quantite; }
            set
            {
                if (Quantite != value)
                {
                    _don.Quantite = value;

                }
            }
        }

        public bool EstPerissable
        {
            get { return _don.EstPerissable; }
            set
            {
                if (_don.EstPerissable != value)
                {
                    _don.EstPerissable = value;
                }
            }
        }

        public bool EstRemis
        {
            get { return _don.EstRemis; }
            set
            {
                if (_don.EstRemis != value)
                {
                    _don.EstRemis = value;
                }
            }
        }

        public DateTime DateReception => _don.DateReception;

        public string Details
        {
            get
            {
                return $"{_don.Quantite} article(s) - {_don.Donateur} - reçu le {_don.DateReception:dd-MM-yyyy}";
            }
        }
    }
}
