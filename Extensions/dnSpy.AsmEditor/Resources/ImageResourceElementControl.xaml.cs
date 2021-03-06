/*
    Copyright (C) 2014-2019 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Windows;
using System.Windows.Controls;
using dnSpy.AsmEditor.ViewHelpers;

namespace dnSpy.AsmEditor.Resources {
	sealed partial class ImageResourceElementControl : UserControl {
		public ImageResourceElementControl() {
			InitializeComponent();
			DataContextChanged += (s, e) => {
				if (DataContext is ImageResourceElementVM data) {
					var ownerWindow = Window.GetWindow(this);
					data.OpenFile = new OpenFile(ownerWindow);
				}
			};
			Loaded += ImageResourceElementControl_Loaded;
		}

		void ImageResourceElementControl_Loaded(object? sender, RoutedEventArgs e) => nameTextBox.Focus();
	}
}
