   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  $    QuanLyThuVien.Screens.NhapSach   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  QUẢN LÝ SÁCH��$	��468��$	��592�� � 
ResizeMode$ CanMinimize=� � DataContext '  !QuanLyThuVien.QuanLySachViewModel   � 	Resources /  )QuanLyThuVien.ListTacGiaToStringConverter   listTacGiaToStringConverter  ErrorTemplate �� 
TargetType �� Triggers P� Property P� Value �� Property	 �� Value
 �� Self �� RelativeSource �� Path��%�   &	        &	      '�� <       �� .R�]� ��. .+��� 
���  ��$��1q�._��� �� " �� P�  �@=�HasError . . ���  �@�ToolTip	 �� # Z
 $) #(Validation.Errors)[0].ErrorContent�.���   	GridStyle#���   � ColumnDefinitions �� $
��264* ��� $
��211* ��� $
��109* � � RowDefinitions �� $	��29* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��41* ��� $	��30* ��� $
��171* �.+��� $��Phiếu nhập sách��$
��Left=�$��7��$	��Top=�$��3��$	��166��$	��574��$��0,5,0,0q�.��� $
��Left=�$	��146��$	��Top=�$	��564��$��0,0,-2,0q�.+�&   System.Windows.Controls.DataGrid  $
��Left=�$��0,10,0,0q�$	��Top=�$	��136��$	��564��   AutoGenerateColumns .  ���� *ListDauSach+ �� SelectedItem �� *SelectedDauSach+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Tên sách��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
TenDauSach+  $ Thể loại��$ *  �� *LoaiSach.TenLoaiSach+  $ 
Tác giả��$ *  �� *	TacGias+ �� 	Converter# [    $ Năm xuất bản��$ *  �� *NamXB+  $ Nhà xuất bản��$ *  �� *NhaXB+  $ Số lượng��$ *  �� *CuonSachs.Count+  $ 
Đơn giá��$ *  �� *TriGia+�� $��Nhập sách��$
��Left=�$	��Top=�$	��248��$��7��$	��254��$��0,10,0,0q�.��� $
��Left=�$	��223��$	��Top=�$	��244��$��0,0,-2,0q� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Tên đầu sách��$
��Left=�$��0,10,0,0q�$	��Top=�$��26��$��91���� $��Thể loại��$
��Left=�$��0,10,0,0q�$��1��$	��Top=�$��91���� $��Năm xuất bản��$��
0,10,153,0q�$��2��$	��Top=��� $��Nhà xuất bản��$
��Left=�$��3��$	��Top=�$��91��$��0,8,0,0q��� $
��Left=�$��23��$��	91,10,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��138������ *
TenDauSach+ �� UpdateSourceTrigger$ 	LostFocus=� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions .  �� NotifyOnValidationError . {��� *
IsEnable+�� $
��Left=�$��23��$��	91,10,0,0q�$��2��$
 Wrap=�$	��Top=�$	��138������ *
NamXuatBan+$ 	LostFocus=� .  .  . {��� *
IsEnable+�� $
��Left=�$��23��$��	91,10,0,0q�$��3��$
 Wrap=�$	��Top=�$	��138������ *
NhaXuatBan+$ 	LostFocus=� .  .  . {��� *
IsEnable+�� -   $��	cbTheLoai��$
��Left=�$��	91,10,0,0q�$��1��$	��Top=�$	��138�� �� DisplayMemberPath$ TenLoaiSach��$��Visible=����� *ListLoaiSach+$ PropertyChanged=� �� Mode$ TwoWay=� �� *SelectedLoaiSach+{��� *
IsEnable+�� $��Số lượng��$
��Left=�$��0,7,0,0q�$	��Top=�$��67��$��4���� $
��Left=�$��23��$��	91,10,0,0q�$
 Wrap=�$	��Top=�$	��138��$��4������ *	SoLuong+$ 	LostFocus=� .  .  . {��� *
IsEnable+�� $��
Đơn giá��$
��Left=�$��0,7,0,0q�$��5��$	��Top=�$��67���� $
��Left=�$��23��$��	91,10,0,0q�$��5��$
 Wrap=�$	��Top=�$	��138������ *TriGia+$ 	LostFocus=� .  .  . {��� *
IsEnable+�� $��1��$��Chi tiết nhập��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��248��$��7��$	��191��.��� $
��Left=�$	��225��$	��Top=�$	��181��$��0,0,-2,0q� �� $	��50* ��� $	��50* ��� $	��50* ��� $	��50* ��� $	��50* �.+��� $��Ngày nhập��$
��Left=�$��0,9,0,0q�$��4��$	��Top=�$��67��(  "System.Windows.Controls.DatePicker  $
��Left=�$��	72,11,0,0q�$��4��$	��Top=�$��99��{�.     SelectedDateFormat$ Short=�   SelectedDate �� *
NgayNhap+$ TwoWay=��� $��
Tác giả��$
��Left=�$��10,9,0,0q�$	��Top=�$��91���� $
��Left=�$	��145��$��4��$	��Top=�$	��161��$��	10,35,0,0q� �� SelectionMode$ Multiple=����� *ListTacGiaView++	   %QuanLyThuVien.MultiSelectorBehaviours   	  SynchronizedSelectedItems  �� *SelectedTacGias+{��� *
IsEnable+���� " ��.���  �@��
IsSelected	 �� $ TwoWay=�$ 
IsSelected����� .R��� ���� $ 	TenTacGia��� $��2��$��Điều khiển��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��248��$��7��$��99��.��� $
��Left=�$	��224��$��0,0,-2,0q�$	��Top=�$��89�� �� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* ��� $	��44* �.+��� $��Thêm mới��$
��Left=�$��	10,10,0,0q�$	��Top=�$��69��$��35��  ButtonStyle#���  ���� *AddNewCommand+�� $
��Lưu��$
��Left=�$��10,4,0,0q�$	��Top=�$��69��$��1��$��35��#���  ���� *SaveCommand+�� $
��Xóa��$
��Left=�$��10,4,0,0q�$	��Top=�$��69��$��3��$��36��#���  ���� *RemoveCommand+�� -   $��btThoat��$��Thoát��$
��Left=�$��10,5,0,0q�$	��Top=�$��69��$��4��$��35��#���  �� $��Sửa��$
��Left=�$��10,4,0,0q�$��2��$	��Top=�$��69��$��34��#���  ���� *EditCommand+