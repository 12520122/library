   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  &     QuanLyThuVien.Screens.LoaiDocGia   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$$  QUẢN LÝ LOẠI ĐỘC GIẢ��$	��336��$��412.5�� � 
ResizeMode$ CanMinimize=� � Icon$7 1/QuanLyThuVien;component/Resources/IconDocGia.ico�� � DataContext *  $QuanLyThuVien.TheLoaiDocGiaViewModel  .���    	GridStyle#���    � ColumnDefinitions �� $
��265* ��� $
��139* � � RowDefinitions �� $	��34* ��� $
��100* ��� $
��131* �.+��� $��LOẠI ĐỘC GIẢ��$
��Left=�$��	111,0,0,0q�$	��Top=�$	��190��$��24(�$��Times New Roman)�$
��Bold"�$��2��$��38��$��2�����	#FFF90101�� $��Loại độc giả��$
��Left=�$��1��$	��245��$��	10,0,0,52q�.��� $
��Left=�$��45��$	��Top=�$	��235��$��0,0,-2,0q� �� $��* �.+��� $��Tên loại độc giả��$
��Left=�$��0,10,0,0q�$��1��$	��Top=�$	��101���� $
��Left=�$��23��$��
115,14,0,0q�$��1�� �� TextWrapping$
 Wrap=�$	��Top=�$	��110������ *TenLoaiDocGia+{��� *
IsEnable+�� $��1��$��Điều khiển��$��1��$	��Top=�$��0,0,10,0q�$	��256��$��2��.��� $
��Left=�$	��235��$	��Top=�$	��119��$��	0,0,-2,-1q� �� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* �.+��� $��Thêm��$
��Left=�$	��Top=�$��99��$��	10,10,0,0q�$��27��  ButtonStyle#���  ���� *AddNewCommand+�� $
��Lưu��$
��Left=�$��	10,10,0,0q�$��1��$	��Top=�$��99��$��27��#���  ���� *SaveCommand+�� $��Sửa��$
��Left=�$��	10,10,0,0q�$��2��$	��Top=�$��99��$��27��#���  ���� *EditCommand+�� $
��Xóa��$
��Left=�$��	10,10,0,0q�$��3��$	��Top=�$��99��$��27��#���  ���� *RemoveCommand+�� -   $��btThoat��$��Thoát��$
��Left=�$	��Top=�$��99��$��	10,10,0,0q�$��4�� J� RenderTransformOrigin$ 0.5,0.5&�$��27��#���  �� $$��Danh sách loại độc giả��$
��Left=�$��1��$	��Top=�$	��245��$	��187��$��	10,69,0,0q�$��2��.��&   System.Windows.Controls.DataGrid  $
��Left=�$	��235��$��
0,10,-2,-2q�   AutoGenerateColumns .  ���� *ListLoaiDocGia+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� SelectedItem �� *SelectLoaiDocGia+$	 TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Mã loại độc giả��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *MaLoaiDocGia+$	 TwoWay=�$
 PropertyChanged=�  $ Tên loại độc giả��$	 140  �� *TenLoaiDocGia+$	 TwoWay=�$
 PropertyChanged=�