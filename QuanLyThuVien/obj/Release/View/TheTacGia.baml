   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  %    QuanLyThuVien.Screens.TheTacGia   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  QUẢN LÝ TÁC GIẢ��$	��336��$	��413�� � 
ResizeMode$ CanMinimize=� � Icon$7 1/QuanLyThuVien;component/Resources/IconTacgia.ico�� � DataContext &   QuanLyThuVien.TheTacGiaViewModel  .���    	GridStyle#���    � ColumnDefinitions �� $	��52* ��� $	��29* � � RowDefinitions �� $��7* ��� $	��23* ��� $	��31* �.+��� $��
TÁC GIẢ��$
��Left=�$��	146,0,0,0q�$��36��$	��Top=�$	��128��$��24(�$��Times New Roman)�$
��Bold"�$��2��$��2�����	#FFFB0303��Z� �� $��Thông tin tác giả��$
��Left=�$��1��$	��Top=�$��10,0,0,0q�$	��240��$��70��.��� $
��Left=�$��47��$��0,4,-2,0q�$	��Top=�$	��230�� �� $��* �.+��� $��Tên tác giả��$
��Left=�$��0,10,0,0q�$��1��$	��Top=�$��84���� $
��Left=�$��23��$��
100,14,0,0q�$��1�� �� TextWrapping$
 Wrap=�$	��Top=�$	��120�� J� 	AllowDrop .  ���� *	TenTacGia+{��� *
IsEnable+�� $��1��$��Điều khiển��$
��Left=�$��1��$	��Top=�$	��135��$	��260��$��2��.��� $
��Left=�$	��125��$��	0,0,-2,-1q�$	��239��$��Bottom=� �� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* �.+��� $��Thêm��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��105��$��28��  ButtonStyle#���  ���� *AddNewCommand+ �� Mode$ TwoWay=��� $
��Lưu��$
��Left=�$��	10,10,0,0q�$��1��$	��Top=�$	��105��$��28��#���  ���� *SaveCommand+$ TwoWay=��� $��Sửa��$
��Left=�$��	10,10,0,0q�$��2��$	��Top=�$	��105��	 J� RenderTransformOrigin$	 0.48,0.5&�$��28��#���  ���� *EditCommand+$ TwoWay=��� $
��Xóa��$	��Top=�$��
10,10,10,0q�$��3��$��28��#���  ���� *RemoveCommand+$ TwoWay=��� -   $��btThoat��$��Thoát��$
��Left=�$	��Top=�$	��105��$��	10,10,0,0q�$��4��$��27��#���  �� $��Danh sách tác giả��$
��Left=�$��	10,75,0,0q�$��1��$	��Top=�$	��240��$	��186��$��2��.��&   System.Windows.Controls.DataGrid  -   
  Name$
 dataGrid��$
��Left=�$��	0,10,-2,0q�$	��Top=�$	��154��$	��230��   AutoGenerateColumns .  ���� *
ListTacGia+ �� SelectedItem �� *SelectedItem+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Tên tác giả��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	TenTacGia+