   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien       QuanLyThuVien.PhieuTraSach   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  PHIẾU TRẢ SÁCH��$	��393��$��548.7�� � 
ResizeMode$ CanMinimize=� � DataContext (  "QuanLyThuVien.ThePhieuTraViewModel  .���    	GridStyle#���    � ColumnDefinitions �� $
��199* ��� $
��209* ��� $
��133* � � RowDefinitions �� $	��39* ��� $
��179* ��� $
��144* �.+��� $��TRẢ SÁCH��$
��Left=�$��30,0,0,0q�$	��Top=�$	��137��$��24(�$
��Bold"�$��Times New Roman)�$��1�����	#FFF30C0C�� $��Độc giả��$
��Left=�$��1��$	��Top=�$	��196��$	��113��.��� $
��Left=�$��83��$��
0,10,-3,-2q�$	��Top=�$	��187�� �� $	��16* ��� $	��16* �.+��� $��Mã độc giả��$
��Left=�$��0,10,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.5,0.5&�$��74���� $��Tên độc giả��$
��Left=�$��0,5,0,0q�$��1��$	��Top=�$��74���� $
��Left=�$��23��$��	74,14,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��31������ *
MaDocGia+�� $
��Left=�$��23��$��74,9,0,0q�$��1��$
 Wrap=�$	��Top=�$	��103��{�.  ���� *	TenDocGia+�� $��Tìm kiếm��$
��Left=�$��
110,14,0,0q�$	��Top=�$��67�� � Cursor$
 Hand��$
��Bold"����	#FF1019E0$��22������ *SearchDocGiaCommand+��Z� ��Z� �� $��2��$��Điều khiển��$
��Left=�$��10,0,0,0q�$��1��$	��Top=�$	��113��$	��169��.��� $
��Left=�$	��136��$��	0,10,-2,0q�$	��Top=�$	��103�� �� $	��43* ��� $	��43* ��� $	��43* �.+��� $��Thêm mới��$
��Left=�$��10,0,0,0q�$	��Top=�$��83��$��35��  ButtonStyle#���  �� $
��Lưu��$
��Left=�$��10,0,0,0q�$��1��$	��Top=�$��83��$��36��#���  ���� *SaveCommand+�� -   $��btThoat��$��Thoát��$
��Left=�$��10,0,0,0q�$��2��$	��Top=�$��83��$��35��#���  �� $��Sách đang mượn��$
��Left=�$��2��$	��Top=�$��2��$	��135��.��&   System.Windows.Controls.DataGrid  $
��Left=�$	��Top=�$	��125��$��	0,0,0,-12q�$	��199��   AutoGenerateColumns .  ���� *
ListLeft+	 �� SelectedItem	 �� *SelectedPhieuMuon+
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã sách��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *CuonSach.MaCuonSach+  $ 
Tên sách�� �� *CuonSach.DauSach.TenDauSach+  $ Ngày mượn�� �� *
NgayMuon+�� $��23��$	��Top=�$��16,39,109,0q�$��2��$��1������ *AddToRightCommand+.��Thêm vào >>�� -   $��RemoveButton��$��1��$��
16,77,0,46q�$��2��$
��Left=�$��85������ *RemoveFromRightCommand+.��
<< Bỏ ra�� $��Sách trả��$��2��$	��Top=�$��2��$	��135��$��	122,0,0,0q�$��1��.��  $
��Left=�$	��Top=�$	��125��$��	0,0,0,-12q� .  ���� *	ListRight+	 �� *SelectedPhieuTra+
   $ 	Mã sách�� �� *PhieuMuon.CuonSach.MaCuonSach+  $ 
Tên sách�� �� *'%PhieuMuon.CuonSach.DauSach.TenDauSach+  $ Ngày mượn�� �� *PhieuMuon.NgayMuon+  $ Số ngày mượn�� �� *
SoNgayMuon+  $ Tiền phạt�� �� *
TienPhat+�� $��Thông tin phiếu trả��$
��Left=�$��4,0,0,0q�$��1��$	��Top=�$	��196��$��51��$��1��.��� $
��Left=�$��30��$��0,0,0,-1q�$	��Top=�$	��180��.+��� $��Ngày trả��$
��Left=�$��0,-1,0,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��56,1,0,0q�$	��Top=�$	��120��{�.     SelectedDate �� *	NgayTra+