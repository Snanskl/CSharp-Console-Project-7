using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class BeautyAndDate
    {
        //This class accessed by BeautyManager
        #region Fields Area
        private ProductType product;
        private DateTime date;
        private string productName;
        private List<MakeupIngrediens> makeupIngrediens;
        private List<SkincareIngrediens> skincareIngrediens;

        #endregion

        #region Constructor area
        public BeautyAndDate() : this(DateTime.Now, "", ProductType.Makeup, ProductType.Makeup, null, null)  //Default constructor
        {
            //As a default productype will always set to skincare
            //This constructor will chain calling the second constructor 
            //that possessed all the argument that passed through
            product = ProductType.Makeup;
            product = ProductType.Skincare;
        }
        public BeautyAndDate(BeautyAndDate copybeautyDate)//Copy constructor
        {
            //This is a copy constructor for returning a copy data instead
            //of an original data 
            this.product = copybeautyDate.product;
            this.date = copybeautyDate.date;
            this.productName = copybeautyDate.productName;
            skincareIngrediens = copybeautyDate.skincareIngrediens;
            makeupIngrediens=copybeautyDate.makeupIngrediens;
        }
        public BeautyAndDate(DateTime date, string productName, ProductType product1, ProductType product2, List<SkincareIngrediens> skincare, List<MakeupIngrediens> makeup) //Chain called constructor
        {
            //This function is to be called by a default constructor
            //In this way, we can still remain a default constructor to remain
            //empty in case we dont need to giv any argument, but if needed
            //this function will be called.

            this.date = date;
            this.productName = productName;
            this.product = product1;
            this.product = product2;
            skincareIngrediens = skincare;
            makeupIngrediens = makeup;
        }
        #endregion 

        #region Manual meethods
        public override string ToString()
        {
            string stringOut = $"{GetProductToString()} {productName, 80} {GetTimeToString(), 78}";

            return stringOut;
        }
        private string GetTimeToString()
        {
            return date.ToString("M");
        }
        private string GetProductToString()
        { 
            return product.ToString();
        }
        public List<string> GentleSkicncareIngrediens()
        {
            //List<SkincareIngrediens> gentleSkincare = new List<SkincareIngrediens>();
            skincareIngrediens = new List<SkincareIngrediens>();

            skincareIngrediens.Add(SkincareIngrediens.Hyaluronic_Acid);
            skincareIngrediens.Add(SkincareIngrediens.Vitamin_C);
            skincareIngrediens.Add(SkincareIngrediens.Niacinamide);
            skincareIngrediens.Add(SkincareIngrediens.Peptides);
            skincareIngrediens.Add(SkincareIngrediens.Ceramides);
            skincareIngrediens.Add(SkincareIngrediens.Natural_oils);
            skincareIngrediens.Add(SkincareIngrediens.Aloe_Vera);
            skincareIngrediens.Add(SkincareIngrediens.Squalane);
            skincareIngrediens.Add(SkincareIngrediens.Centella_Asiatica);
            skincareIngrediens.Add(SkincareIngrediens.Green_Tea_Extract);
            skincareIngrediens.Add(SkincareIngrediens.Allantoin);
            skincareIngrediens.Add(SkincareIngrediens.Probiotics);
            skincareIngrediens.Add(SkincareIngrediens.Shea_Butter);
            skincareIngrediens.Add(SkincareIngrediens.Licorice_Extract);
            skincareIngrediens.Add(SkincareIngrediens.Vitamin_E);
            skincareIngrediens.Add(SkincareIngrediens.Rosemary_Extract);

            //gentleSkincare.Add(SkincareIngrediens.Hyaluronic_Acid);
            //gentleSkincare.Add(SkincareIngrediens.Vitamin_C);
            //gentleSkincare.Add(SkincareIngrediens.Niacinamide);
            //gentleSkincare.Add(SkincareIngrediens.Peptides);
            //gentleSkincare.Add(SkincareIngrediens.Ceramides);
            //gentleSkincare.Add(SkincareIngrediens.Natural_oils);
            //gentleSkincare.Add(SkincareIngrediens.Aloe_Vera);
            //gentleSkincare.Add(SkincareIngrediens.Squalane);
            //gentleSkincare.Add(SkincareIngrediens.Centella_Asiatica);
            //gentleSkincare.Add(SkincareIngrediens.Green_Tea_Extract);
            //gentleSkincare.Add(SkincareIngrediens.Allantoin);
            //gentleSkincare.Add(SkincareIngrediens.Probiotics);
            //gentleSkincare.Add(SkincareIngrediens.Shea_Butter);
            //gentleSkincare.Add(SkincareIngrediens.Licorice_Extract);
            //gentleSkincare.Add(SkincareIngrediens.Vitamin_E);
            //gentleSkincare.Add(SkincareIngrediens.Rosemary_Extract);

            List<string> skincareIngrediensString = new List<string>();

            foreach (SkincareIngrediens ingredient in skincareIngrediens)
            {
                skincareIngrediensString.Add(ingredient.ToString());
            }

            return skincareIngrediensString;
        }
        public List<string> NeutralSkincareIngrediens()
        {
            //List<SkincareIngrediens> neutralSkincare = new List<SkincareIngrediens>();

            skincareIngrediens = new List<SkincareIngrediens>();

            skincareIngrediens.Add(SkincareIngrediens.Retinoids);
            skincareIngrediens.Add(SkincareIngrediens.Glycolic_Acid);
            skincareIngrediens.Add(SkincareIngrediens.Resveratrol);

            //neutralSkincare.Add(SkincareIngrediens.Retinoids);
            //neutralSkincare.Add(SkincareIngrediens.Glycolic_Acid);
            //neutralSkincare.Add(SkincareIngrediens.Resveratrol);

            List<string> skincareIngrediensString = new List<string>();

            foreach (SkincareIngrediens ingredient in skincareIngrediens)
            {
                skincareIngrediensString.Add(ingredient.ToString());
            }

            return skincareIngrediensString;
        }
        public List<string> IrritationSkincareIngrediens()
        {
            //List<SkincareIngrediens> irritationSkincare = new List<SkincareIngrediens>();
            skincareIngrediens = new List<SkincareIngrediens>();

            skincareIngrediens.Add(SkincareIngrediens.Alpha_Hydroxy_Acids);
            skincareIngrediens.Add(SkincareIngrediens.Beta_Hydroxy_Acid);
            skincareIngrediens.Add(SkincareIngrediens.Benzoyl_Peroxide);
            skincareIngrediens.Add(SkincareIngrediens.Tea_Tree_Oil);


            //irritationSkincare.Add(SkincareIngrediens.Alpha_Hydroxy_Acids);
            //irritationSkincare.Add(SkincareIngrediens.Beta_Hydroxy_Acid);
            //irritationSkincare.Add(SkincareIngrediens.Benzoyl_Peroxide);
            //irritationSkincare.Add(SkincareIngrediens.Tea_Tree_Oil);

            List<string> skincareIngrediensString = new List<string>();

            foreach (SkincareIngrediens ingredient in skincareIngrediens)
            {
                skincareIngrediensString.Add(ingredient.ToString());
            }

            return skincareIngrediensString;
        }
        public List<string>  GentleMakeupIngrediens()
        {
            //List<MakeupIngrediens> gentleMakeUp = new List<MakeupIngrediens>();
            makeupIngrediens = new List<MakeupIngrediens>();

            makeupIngrediens.Add(MakeupIngrediens.Talc);
            makeupIngrediens.Add(MakeupIngrediens.Titanium_Dioxide);
            makeupIngrediens.Add(MakeupIngrediens.Silica);
            makeupIngrediens.Add(MakeupIngrediens.Mica);
            makeupIngrediens.Add(MakeupIngrediens.Kaolin);
            makeupIngrediens.Add(MakeupIngrediens.Dimethicone);
            makeupIngrediens.Add(MakeupIngrediens.Tocopherol);
            makeupIngrediens.Add(MakeupIngrediens.Fragrance);


            //gentleMakeUp.Add(MakeupIngrediens.Talc);
            //gentleMakeUp.Add(MakeupIngrediens.Titanium_Dioxide);
            //gentleMakeUp.Add(MakeupIngrediens.Silica);
            //gentleMakeUp.Add(MakeupIngrediens.Mica);
            //gentleMakeUp.Add(MakeupIngrediens.Kaolin);
            //gentleMakeUp.Add(MakeupIngrediens.Dimethicone);
            //gentleMakeUp.Add(MakeupIngrediens.Tocopherol);
            //gentleMakeUp.Add(MakeupIngrediens.Fragrance);

            List<string> makeupIngrediensString = new List<string>();

            foreach (MakeupIngrediens ingredient in makeupIngrediens)
            {
                makeupIngrediensString.Add(ingredient.ToString());
            }

            return makeupIngrediensString;
        }
        public List<string> NeutralMakeupIngrediens()
        {
            //List<MakeupIngrediens> neutralMakeup = new List<MakeupIngrediens>();
            makeupIngrediens = new List<MakeupIngrediens>();

            makeupIngrediens.Add(MakeupIngrediens.Iron_Oxides);
            makeupIngrediens.Add(MakeupIngrediens.Synthetic_Fluorphlogopite);
            makeupIngrediens.Add(MakeupIngrediens.Carmine);
            makeupIngrediens.Add(MakeupIngrediens.Parabens);
            makeupIngrediens.Add(MakeupIngrediens.Synthetic_Waxes);
            makeupIngrediens.Add(MakeupIngrediens.Butylene_Glycol);
            makeupIngrediens.Add(MakeupIngrediens.Silica_Dimethyl_Silylate);
            makeupIngrediens.Add(MakeupIngrediens.Synthetic_Polymers);


            //neutralMakeup.Add(MakeupIngrediens.Iron_Oxides);
            //neutralMakeup.Add(MakeupIngrediens.Synthetic_Fluorphlogopite);
            //neutralMakeup.Add(MakeupIngrediens.Carmine);
            //neutralMakeup.Add(MakeupIngrediens.Parabens);
            //neutralMakeup.Add(MakeupIngrediens.Synthetic_Waxes);
            //neutralMakeup.Add(MakeupIngrediens.Butylene_Glycol);
            //neutralMakeup.Add(MakeupIngrediens.Silica_Dimethyl_Silylate);
            //neutralMakeup.Add(MakeupIngrediens.Synthetic_Polymers);

            List<string> makeupIngrediensString = new List<string>();

            foreach (MakeupIngrediens ingredient in makeupIngrediens)
            {
                makeupIngrediensString.Add(ingredient.ToString());
            }

            return makeupIngrediensString;
        }
        public List<string> IrritationMakeupIngrediens()
        {
            //List<MakeupIngrediens> irritationMakeup = new List<MakeupIngrediens>();
            makeupIngrediens = new List<MakeupIngrediens>();

            makeupIngrediens.Add(MakeupIngrediens.Phenoxyethanol);
            makeupIngrediens.Add(MakeupIngrediens.Retinyl_Palmitate);
            makeupIngrediens.Add(MakeupIngrediens.Bismuth_Oxychloride);
            makeupIngrediens.Add(MakeupIngrediens.Nylon_12);

            //irritationMakeup.Add(MakeupIngrediens.Phenoxyethanol);
            //irritationMakeup.Add(MakeupIngrediens.Retinyl_Palmitate);
            //irritationMakeup.Add(MakeupIngrediens.Bismuth_Oxychloride);
            //irritationMakeup.Add(MakeupIngrediens.Nylon_12);

            List<string> makeupIngrediensString = new List<string>();

            foreach (MakeupIngrediens ingredient in makeupIngrediens)
            {
                makeupIngrediensString.Add(ingredient.ToString());
            }

            return makeupIngrediensString;
        }

        #endregion

        #region Property Area 
        public ProductType Product
        {
            //Since the enum is already settled than we dont need to 
            //validate anything
            get => this.product; 
            set => this.product = value; 
        }
        public DateTime Date
        {
            //Since date cant be null than we dont need to validate anything
            get => this.date; 
            set => this.date = value; 
        }
        public string ProductName
        {
            get => this.productName; 
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    productName = value;
                }
            }
        }
        public List<MakeupIngrediens> MakeupIngrediensProperty
        {
            get => makeupIngrediens; 
            set => makeupIngrediens = value; 
        }
        public List<SkincareIngrediens> SkincareIngrediensProperty
        {
            get => skincareIngrediens; 
            set => skincareIngrediens = value; 
        }

        #endregion
    }
}
