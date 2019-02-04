using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaterialHouse.Behaviors
{
    public class TabbedPageDemoPageCS : TabbedPage
    {
        public TabbedPageDemoPageCS()
        {
            var booleanConverter = new NonNullToBooleanConverter();

            ItemTemplate = new DataTemplate(() => {
                var nameLabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    FontAttributes = FontAttributes.Bold,
                    HorizontalOptions = LayoutOptions.Center
                };
                nameLabel.SetBinding(Label.TextProperty, "Name");

                var image = new Image { WidthRequest = 200, HeightRequest = 200 };
                image.SetBinding(Image.SourceProperty, "Address");

                var familyLabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontAttributes = FontAttributes.Bold
                };
                familyLabel.SetBinding(Label.TextProperty, "Type");

                var subFamilyLabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontAttributes = FontAttributes.Bold
                };
                subFamilyLabel.SetBinding(Label.TextProperty, "Subfamily");

                var tribeLabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontAttributes = FontAttributes.Bold
                };
                tribeLabel.SetBinding(Label.TextProperty, "Tribe");

                var genusLabel = new Label
                {
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                    FontAttributes = FontAttributes.Bold
                };
                genusLabel.SetBinding(Label.TextProperty, "Genus");

                var subFamilyStackLayout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {
                        new Label { Text = "Subfamily:", HorizontalOptions = LayoutOptions.FillAndExpand },
                        subFamilyLabel
                    }
                };
                subFamilyStackLayout.SetBinding(VisualElement.IsVisibleProperty, new Binding("Subfamily", BindingMode.Default, booleanConverter));

                var tribeStackLayout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {
                        new Label { Text = "Tribe:", HorizontalOptions = LayoutOptions.FillAndExpand },
                        tribeLabel
                    }
                };
                tribeStackLayout.SetBinding(VisualElement.IsVisibleProperty, new Binding("Tribe", BindingMode.Default, booleanConverter));

                var contentPage = new ContentPage
                {
                    Icon = "logo.png",
                    Content = new StackLayout
                    {
                        Padding = new Thickness(5, 25),
                        Children = {
                            nameLabel,
                            image,
                            new StackLayout {
                                Padding = new Thickness (50, 10),
                                Children = {
                                    new StackLayout {
                                        Orientation = StackOrientation.Horizontal,
                                        Children = {
                                            new Label { Text = "Type:", HorizontalOptions = LayoutOptions.FillAndExpand },
                                            familyLabel
                                        }
                                    },
                                    subFamilyStackLayout,
                                    tribeStackLayout,
                                    new StackLayout {
                                        Orientation = StackOrientation.Horizontal,
                                        Children = {
                                            new Label { Text = "Type:", HorizontalOptions = LayoutOptions.FillAndExpand },
                                            genusLabel
                                        }
                                    }
                                }
                            }

                        }
                    }
                };
                contentPage.SetBinding(TitleProperty, "Type");

                return contentPage;
            });

            //ItemsSource = MonkeyDataModel.All;

        }
    }
}
