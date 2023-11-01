using System.Windows;
using System.Windows.Media;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using XamlDesign.Wpf.UI.Units;
using Jamesnet.Wpf.Controls;

namespace Anatomy.Extensions
{
    public enum Theme
    {
        Light,
        Black
    }

    public static class ControlDataExtensions
    {
        public static Button InitSampleData(this Button button, Theme theme)
        {
            button.Content = "Sample Button";
            button.Padding = new Thickness(10);
            ApplyTheme(button, theme);
            return button;
        }

        public static Slider InitSampleData(this Slider slider, Theme theme)
        {
            slider.Width = 200;
            slider.Value = 20;
            slider.Maximum = 100;
            ApplyTheme(slider, theme);
            return slider;
        }

        public static ComboBox InitSampleData(this ComboBox comboBox, Theme theme)
        {
            List<SampleModel> sampleItems = new List<SampleModel>
            {
                new SampleModel { Id = 1, Name = "Option 1", Description = "Description 1" },
                new SampleModel { Id = 2, Name = "Option 2", Description = "Description 2" },
                new SampleModel { Id = 3, Name = "Option 3", Description = "Description 3" }
            };

            comboBox.ItemsSource = sampleItems;
            comboBox.SelectedIndex = 0;
            ApplyTheme(comboBox, theme);
            return comboBox;
        }

        public static TextBox InitSampleData(this TextBox textBox, Theme theme)
        {
            textBox.Text = "Sample Text";
            ApplyTheme(textBox, theme);
            return textBox;
        }

        public static CheckBox InitSampleData(this CheckBox checkBox, Theme theme)
        {
            checkBox.Content = "Sample CheckBox";
            checkBox.IsChecked = true;
            ApplyTheme(checkBox, theme);
            return checkBox;
        }

        public static RadioButton InitSampleData(this RadioButton radioButton, Theme theme)
        {
            radioButton.Content = "Sample RadioButton";
            radioButton.IsChecked = true;
            ApplyTheme(radioButton, theme);
            return radioButton;
        }

        public static ListBox InitSampleData(this ListBox listBox, Theme theme)
        {
            List<SampleModel> sampleItems = new List<SampleModel>
            {
                new SampleModel { Id = 1, Name = "Item 1", Description = "Description 1" },
                new SampleModel { Id = 2, Name = "Item 2", Description = "Description 2" },
                new SampleModel { Id = 3, Name = "Item 3", Description = "Description 3" }
            };

            listBox.ItemsSource = sampleItems;
            listBox.SelectedIndex = 0;
            ApplyTheme(listBox, theme);
            return listBox;
        }

        public static UnderlineMenuBox InitSampleData(this UnderlineMenuBox listBox, Theme theme)
        {
            UnderlineMenuBoxItem item1 = new() { Content = "Microsoft", Icon = IconType.Microsoft };
            UnderlineMenuBoxItem item2 = new() { Content = "Apple", Icon = IconType.Apple };
            UnderlineMenuBoxItem item3 = new() { Content = "Netflix", Icon = IconType.Netflix };
            listBox.Items.Add(item1);
            listBox.Items.Add(item2);
            listBox.Items.Add(item3);
            listBox.SelectedIndex = 0;
            ApplyTheme(listBox, theme);
            return listBox;
        }

        public static Expander InitSampleData(this Expander expander, Theme theme)
        {
            expander.Header = "Sample Expander Header";
            expander.Content = "This is the content inside the expander.";
            ApplyTheme(expander, theme);
            return expander;
        }

        public static GroupBox InitSampleData(this GroupBox groupBox, Theme theme)
        {
            groupBox.Header = "Sample GroupBox Header";
            groupBox.Content = "This is the content inside the groupBox.";
            ApplyTheme(groupBox, theme);
            return groupBox;
        }

        public static ToggleButton InitSampleData(this ToggleButton toggleButton, Theme theme)
        {
            toggleButton.Content = "Sample Toggle";
            toggleButton.IsChecked = false;
            toggleButton.Padding = new Thickness(10);
            ApplyTheme(toggleButton, theme);
            return toggleButton;
        }

        public static TabControl InitSampleData(this TabControl tabControl, Theme theme)
        {
            var tabItem1 = new TabItem
            {
                Header = "Tab 1",
                Content = "Content of Tab 1",
                Padding = new Thickness(10),
            };
            var tabItem2 = new TabItem
            {
                Header = "Tab 2",
                Content = "Content of Tab 2",
                Padding = new Thickness(10)
            };

            tabControl.Items.Add(tabItem1);
            tabControl.Items.Add(tabItem2);
            tabControl.Padding = new(10);
            ApplyTheme(tabControl, theme);
            return tabControl;
        }

        public static DataGrid InitSampleData(this DataGrid dataGrid, Theme theme)
        {
            List<SampleModel> sampleData = new List<SampleModel>
            {
                new SampleModel { Id = 1, Name = "Item 1", Description = "Description 1" },
                new SampleModel { Id = 2, Name = "Item 2", Description = "Description 2" },
                new SampleModel { Id = 3, Name = "Item 3", Description = "Description 3" }
            };

            dataGrid.ItemsSource = sampleData;
            dataGrid.AutoGenerateColumns = true;
            ApplyTheme(dataGrid, theme);
            return dataGrid;
        }

        private static void ApplyTheme(Control control, Theme theme)
        {
            switch (theme)
            {
                case Theme.Light:
                    control.Background = Brushes.White;
                    control.Foreground = Brushes.Black;
                    break;
                case Theme.Black:
                    control.Background = Brushes.Black;
                    control.Foreground = Brushes.White;
                    break;
            }
        }
    }

    public class SampleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // ToString() 메서드를 재정의하여 ListBox에 표시될 문자열을 지정합니다.
        public override string ToString()
        {
            return $"{Name} - {Description}";
        }
    }
}

