   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  $    QuanLyThuVien.PhieuThuTienPhat   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  PHIẾU THU TIỀN PHẠT��$	��362��$��660.3�� � 
ResizeMode$ CanMinimize=� � Icon$1 +/QuanLyThuVien;component/Resources/tien.png�� � DataContext )  #QuanLyThuVien.PhieuThuTienViewModel   � 	Resources    ErrorTemplate �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� Self �� RelativeSource �� Path��%�   &	        '�� 7     �� .R�]� ��. .+��� 
���  ��$��1q�._��� �� " �� P�  �@=�HasError . . ��� 	 �@�ToolTip
 �� # Z $) #(Validation.Errors)[0].ErrorContent�.���   	GridStyle#���   � RowDefinitions �� $	��40* ��� $
��291* � � ColumnDefinitions �� $
��324* ��� $
��207* ��� $
��121* �.+��� $��PHIẾU THU TIỀN��$
��Left=�$��	190,0,0,0q�$	��Top=�$��Times New Roman)�$��24(�$
��Bold"�$��2��$	��213�����	#FFF90101�� $��Độc giả��$
��Left=�$��1��$	��Top=�$	��314��$	��281��.��� $
��Left=�$	��259��$	��Top=�$	��304��$��0,0,-2,0q� �� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* �.+��� $��Mã độc giả��$
��Left=�$��0,9,0,0q�$	��Top=�$��86���� $��Tên độc giả��$
��Left=�$��0,10,0,0q�$��1��$	��Top=�$��86���� $��
Ngày sinh��$
��Left=�$��0,10,0,0q�$��3��$	��Top=�$��86���� $��Địa chỉ��$
��Left=�$��0,10,0,0q�$��4��$	��Top=�$��86���� $��Email��$
��Left=�$��0,11,0,0q�$��5��$	��Top=�$��86���� $��Tổng nợ��$
��Left=�$��0,10,0,0q�$��6��$	��Top=�$��86���� $
��Left=�$��23��$��
118,14,0,0q�$��1�� �� TextWrapping$
 Wrap=�{�.  $	��Top=�$	��176������ *SelectedDocGia.HoTen+ �� Mode$ TwoWay=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��
118,11,0,0q�$��3��$	��Top=�$	��176��{�.     SelectedDate �� *SelectedDocGia.NgaySinh+�� $
��Left=�$��23��$��
118,14,0,0q�$��4��$
 Wrap=�$	��Top=�$	��176��{�.  ���� *SelectedDocGia.DiaChi+�� $
��Left=�$��23��$��
118,15,0,0q�$��5��$
 Wrap=�$	��Top=�$	��176��$��2��{�.  ���� *SelectedDocGia.Email+�� $
��Left=�$��23��$��
118,10,0,0q�$��6��$
 Wrap=�$	��Top=�$	��176��{�.  ���� *SelectedDocGia.TongNo+�� $
��Left=�$��	118,5,0,0q�$	��Top=�$	��176�� �� DisplayMemberPath$ MaDocGia��$��Visible=�{��� *
IsEnable+���� *
ListDocGia+$ TwoWay=� �� SelectedItem �� *SelectedDocGia+$ TwoWay=��� $��1��$��
Thu tiền��$
��Left=�$��1��$	��Top=�$	��197��$	��178��$��	0,103,0,0q�.��� $
��Left=�$	��152��$	��Top=�$	��187��$��0,0,-2,0q� �� $	��22* ��� $	��23* �.+��� $��Số tiền thu��$
��Left=�$��0,12,0,0q�$	��Top=�$��73���� $��
Còn lại��$
��Left=�$��0,10,0,0q�$��1��$	��Top=�$��73���� $
��Left=�$��23��$��	78,16,0,0q�$
 Wrap=�$	��Top=�$��99�� �� TextAlignment$ Right=�{��� *
IsEnable+���� *SoTien+ �� UpdateSourceTrigger$ PropertyChanged=��� $
��Left=�$��23��$��	78,14,0,0q�$��1��$
 Wrap=�$	��Top=�$��99��$ Right=�{�.  ���� *ConLai+$ TwoWay=��� $��2��$��Điều khiển��$
��Left=�$��1��$	��Top=�$	��121��$	��281��.��� $
��Left=�$	��258��$	��Top=�$	��111��$��0,0,-2,0q� �� $��* ��� $��* ��� $��* �.+��� -    ��Name$ 	btThuTien��$��
Thu tiền��$
��Left=�$��10,9,0,0q�$	��Top=�$��91��$��49��  ButtonStyle#���  $��16(�$��1������ *SaveCommand+�� -   $ btThoat��$��Thoát��$
��Left=�$��10,9,0,0q�$��2��$	��Top=�$��91��$��48��#���  $��16(��� $��	Thu mới��$
��Left=�$��	10,10,0,0q�$	��Top=�$��91��#���  $��49��$��16(����� *AddNewCommand+�� $��1��$��Chi tiết phiếu thu��$
��Left=�$��1��$	��Top=�$	��197��$��88��.��� $
��Left=�$��65��$	��Top=�$	��187��$��0,0,-2,0q� �� .+��� $��	Ngày thu��$
��Left=�$��0,21,0,0q�$��1��$	��Top=�$��81��  $
��Left=�$��	58,22,0,0q�$��1��$	��Top=�$	��119��|�.   �� *	NgayThu+{��� *
IsEnable+