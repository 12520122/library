   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  !    QuanLyThuVien.PhieuMuonSach   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  PHIẾU MƯỢN SÁCH��$	��500��$��573.5�� � 
ResizeMode$ CanMinimize=� � DataContext *   $QuanLyThuVien.PhieuMuonSachViewModel  .��� $��0,0,2,2q�   	GridStyle#���    � ColumnDefinitions �� $
��223* ��� $
��224* ��� $
��117* � � RowDefinitions �� $	��39* ��� $
��227* ��� $
��201* �.+��� $��Độc giả��$
��Left=�$	��213��$��1��.��� $
��Left=�$	��203��$	��Top=�$	��203��$��	0,0,-2,-3q� �� $	��30* ��� $	��30* ��� $	��30* ��� $	��30* ��� $	��30* ��� $	��30* ��� $	��30* �.+��� $��Mã độc giả��$
��Left=�$	��Top=�$��78��$��0,2,0,0q��� $��	Họ tên��$
��Left=�$��1��$	��Top=��� $��Loại độc giả��$
��Left=�$��2��$	��Top=��� $��
Ngày sinh��$
��Left=�$��3��$	��Top=��� $��	77,2,82,1q� �� TextWrapping$
 Wrap=����� *
MaDocGia+{��� *
IsEnable+�� $
��Left=�$��23��$��77,4,0,0q�$��1��$
 Wrap=�$	��Top=�$	��116��{�.  ���� *HoTen+ �� Mode$ TwoWay=��� $
��Left=�$��23��$��77,4,0,0q�$��2��$
 Wrap=�$	��Top=�$	��116��{�.  ���� *
LoaiDocGia+$ TwoWay=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��77,2,0,0q�$��3��$	��Top=�$	��116��   IsTodayHighlighted . {�.     SelectedDate �� *
NgaySinh+$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� $��Địa chỉ��$
��Left=�$��0,2,0,0q�$��4��$	��Top=��� $��Email��$
��Left=�$��0,4,0,0q�$��5��$	��Top=��� $��Ngày hết hạn��$
��Left=�$��6��$	��Top=��� $
��Left=�$��23��$��77,5,0,0q�$��4��$
 Wrap=�$	��Top=�$	��116��{�.  ���� *DiaChi+$ TwoWay=��� $
��Left=�$��23��$��77,4,0,0q�$��5��$
 Wrap=�$	��Top=�$	��116��{�.  ���� *Email+$ TwoWay=�  $
��Left=�$��77,3,0,0q�$��6��$	��Top=�$	��116��{�.  $��23�� �� *
NgayHetHan+$ TwoWay=�$	 PropertyChanged=��� $��Tìm kiếm��$
��Left=�$��	126,2,0,0q�$	��Top=�$��67��
 � Cursor$

 Hand��$
��Bold"����	#FF1019E0$��26������ *SearchDocGiaCommand+��Z� ��Z� �� $��MƯỢN SÁCH��$
��Left=�$��	201,0,0,0q�$	��Top=�$	��190��$��24(�$
��Bold"�$��Times New Roman)�$��41��$��2��$��2�����	#FFF90404�� $��Phiếu mượn sách��$
��Left=�$��2��$	��Top=�$	��564��$	��196��$��0,5,0,0q�$��3���� $��1��$��Sách��$
��Left=�$��10,0,0,0q�$��1��$	��Top=�$	��222��$	��204��.��� $
��Left=�$	��199��$	��Top=�$	��194��$��0,0,-2,0q� �� $��* ��� $��* ��� $��* �.+��� $��	Mã sách��$
��Left=�$��0,10,0,0q�$	��Top=��� $��
Tên sách��$
��Left=�$��0,10,0,0q�$��1��$	��Top=��� $
��Left=�$��23��$��72,7,0,0q�$
 Wrap=�$	��Top=�$��49������ *
MaCuonSach+$ TwoWay=� �� ValidatesOnDataErrors . $	 	LostFocus=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . �� $
��Left=�$��23��$��72,7,0,0q�$��1��$
 Wrap=�$	��Top=�$	��112��{�.  ���� *
TenDauSach+$ TwoWay=��� $��Tìm kiếm��$
��Left=�$��	126,7,0,0q�$	��Top=�$��58��$
��Bold"����	#FF1019E0$

 Hand��$��23������ *SearchSachCommand+��Z� ��Z� �� $��Thêm��$
��Left=�$��	87,14,0,0q�$��2��$	��Top=�$��97��  ButtonStyle#���  $��43������ *AddCuonSachCommand+�� $��2��$��Điều khiển��$
��Left=�$��10,0,0,0q�$��1��$	��Top=�$	��107��$	��222��.��� $
��Left=�$	��199��$��0,0,-2,0q�$	��Top=�$��97�� �� $��* ��� $��* ��� $��* �.+��� $��Mượn mới��$
��Left=�$��	12,10,0,0q�$	��Top=�$��75��$��46��#���  ���� *AddNewCommand+�� $��Cho mượn��$
��Left=�$��	12,10,0,0q�$��1��$	��Top=�$��75��$��46��#���  ���� *SaveCommand+�� -   $��btThoat��$��Thoát��$
��Left=�$��	12,10,0,0q�$��2��$	��Top=�$��75��$��47��#���  � $��3��$
��Left=�$��0,26,0,0q�$��2��$	��564�� �� $	��37* ��� $
��138* �.+��� $��Ngày mượn��$
��Left=�$��59,0,0,0q�$	��Top=�$��81��  $
��Left=�$��	145,3,0,0q�$	��Top=�$	��103��|�.   �� *
NgayMuon+$ TwoWay=�$	 PropertyChanged=��� $��Danh sách sách mượn��$
��Left=�$��1��$	��Top=�$	��544��$��10,0,0,0q�$	��138��.��&   System.Windows.Controls.DataGrid  $
��Left=�$��
0,10,-2,-1q�$	��Top=�$	��107��$	��534��   AutoGenerateColumns .  ���� *ListCuonSach+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã sách��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
MaCuonSach+  $ 
Tên sách��$ *  �� *DauSach.TenDauSach+�� $��Số sách mượn��$
��Left=�$��	360,2,0,0q�$	��Top=��� $
��Left=�$��23��$��	450,4,0,0q�$
 Wrap=�$	��Top=�$��67��{�.  ���� *	SoLuong+