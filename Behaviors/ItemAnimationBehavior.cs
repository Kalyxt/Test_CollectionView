using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CollectionView.Behaviors
{
    public class ItemAnimationBehavior : Behavior<VisualElement>
    {
        public static readonly BindableProperty ShouldAnimateProperty = BindableProperty.Create
            (nameof(ShouldAnimateProperty),
            returnType: typeof(bool),
            typeof(VisualElement),
            defaultValue: false,
            propertyChanged: OnShouldAnimateChanged);

        public static void SetShouldAnimate(BindableObject view, VisualElement value) =>
            view.SetValue(ShouldAnimateProperty, value);

        static async void OnShouldAnimateChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((bool)newValue)
            {
                await Animate((VisualElement)bindable);
            }
        }

        /// <summary>
        /// Implemenation of Animation logic
        /// </summary>  
        static private async Task Animate(VisualElement elementToAnimate)
        {
            await elementToAnimate.TranslateTo(-30, 0, 100);
            await elementToAnimate.TranslateTo(60, 0, 100);
            await elementToAnimate.TranslateTo(-30, 0, 100);
        }

    }
}
