   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien       QuanLyThuVien.DanhSachSach   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  TRA CỨU SÁCH��$	��357��$	��494�� � 
ResizeMode$ CanMinimize=� � DataContext )  #QuanLyThuVien.DanhSachSachViewModel   � 	Resources /  )QuanLyThuVien.ListTacGiaToStringConverter   listTacGiaToStringConverter&   QuanLyThuVien.TinhTrangConverter  tinhTrangConverter��%   &	        &	          .��� $��0,0,2,-1q�  	GridStyle#���   � RowDefinitions �� $
��118* ��� $
��209* � � ColumnDefinitions �� .+�&   System.Windows.Controls.DataGrid  $
��Left=�$��0,10,0,0q�$	��Top=�$	��197��$	��484��   AutoGenerateColumns .  $��1��$ �� IsSynchronizedWithCurrentItem$
 TrueY����� *DauSachCollection+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 	Mã sách��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 70 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
MaCuonSach+  $	 
Tên sách��$	
 150  �� *DauSach.TenDauSach+  $	 Thể loại��$
 90  �� *DauSach.LoaiSach.TenLoaiSach+  $	 
Tác giả��$
 90  �� *DauSach.TacGias+ �� 	Converter# [    $	 Tình trạng��$
 90  �� *TinhTrangSach+# [ �� $��	Tra cứu��$
��Left=�$��0,10,0,0q�$	��Top=�$	��374��$	��106��.��� $
��Left=�$��85��$	��Top=�$	��364��$��	0,0,-2,-1q� �� $	��37* ��� $	��37* �.+��� $��Chọn mục tìm kiếm��$
��Left=�$��0,10,0,0q�$	��Top=��� $��Nội dung tìm kiếm��$
��Left=�$��0,10,0,0q�$	��Top=�$��1��$	��113���� $
��Left=�$��
149,10,0,0q�$	��Top=�$	��205��$��26������ *
ListSearch+ �� SelectedItem �� *SelectedSearch+�� $
��Left=�$��27��$��
149,10,0,0q�$��1�� �� TextWrapping$
 Wrap=�$	��Top=�$	��205������ *SearchContent+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $��Điều khiển��$
��Left=�$	��Top=�$	��102��$	��106��$��
379,10,0,0q�.��� $
��Left=�$��86��$��	0,0,-2,-2q�$	��Top=�$��92�� �� $��* ��� $��* �.+��� -    ��Name$ btThoat��$��Thoát��$
��Left=�$��	10,0,0,10q�$��1��$��Bottom=�$��75��$��27��  ButtonStyle#���   J� RenderTransformOrigin$ 
0.52,0.444&�