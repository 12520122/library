   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien      QuanLyThuVien.TheLoaiSach   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  QUẢN LÝ LOẠI SÁCH��$	��336��$	��412�� � 
ResizeMode$ CanMinimize=� � DataContext (  "QuanLyThuVien.TheLoaiSachViewModel  .���    	GridStyle#���    � ColumnDefinitions �� $	��67* ��� $	��34* � � RowDefinitions �� $	��33* ��� $
��112* ��� $
��160* �.+��� $��LOẠI SÁCH��$
��Left=�$��	128,0,0,0q�$	��Top=�$	��146��$��24(�$��Times New Roman)�$
��Bold"�$��38��$��2��$��2�����	#FFF70303�� $��Thông tin loại sách��$
��Left=�$��10,0,0,0q�$��1��$	��Top=�$	��248��$��65��.��� $
��Left=�$��45��$��0,0,-2,0q�$	��Top=�$	��238�� �� $��* �.+��� $��Tên loại sách��$
��Left=�$��0,8,0,0q�$��1��$	��Top=�$��88���� $
��Left=�$��23��$��
103,12,0,0q�$��1�� �� TextWrapping$
 Wrap=�$	��Top=�$	��125������ *TenLoaiSach+{��� *
IsEnable+�� $��1��$��Điều khiển��$
��Left=�$��1��$	��Top=�$	��126��$	��262��$��2��.��� $
��Left=�$	��116��$��	0,0,-2,-2q� �� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* �.+��� $��Thêm��$
��Left=�$��	10,10,0,0q�$	��Top=�$��96��$��28��  ButtonStyle#���  ���� *AddNewCommand+�� $
��Lưu��$
��Left=�$��	10,10,0,0q�$��1��$	��Top=�$��96��$��28��#���  ���� *SaveCommand+�� $��Sửa��$
��Left=�$��	10,10,0,0q�$��2��$	��Top=�$��96��$��29��#���  ���� *EditCommand+�� $
��Xóa��$
��Left=�$��	10,10,0,0q�$��3��$	��Top=�$��96��$��28��#���  ���� *RemoveCommand+�� -   $��btThoat��$��Thoát��$
��Left=�$��	10,10,0,0q�$��4��$	��Top=�$��96��$��29��#���  �� $��Danh sách loại sách��$
��Left=�$��	10,70,0,0q�$��1��$	��Top=� J� RenderTransformOrigin$ 0.507,0.435&�$	��248��$	��193��$��2��.��&   System.Windows.Controls.DataGrid  $
��Left=�$��	0,10,-2,0q�$	��Top=�$	��161��$	��238��   AutoGenerateColumns .  ���� *ListLoaiSach+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� SelectedItem
 �� *SelectLoaiSach+$ TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã loại sách��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
MaLoaiSach+$ TwoWay=�$	 PropertyChanged=�  $ Tên loại sách��$	 140  �� *TenLoaiSach+$ TwoWay=�$	 PropertyChanged=�