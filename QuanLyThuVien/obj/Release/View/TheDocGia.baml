   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien      QuanLyThuVien.TheDocGia   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  THẺ ĐỘC GIẢ��$	��448��$	��769�� � Icon$7 1/QuanLyThuVien;component/Resources/IconDocGia.ico�� � 
ResizeMode$ CanMinimize=� � DataContext &   QuanLyThuVien.TheDocGiaViewModel   � 	Resources    ErrorTemplate �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� Self �� RelativeSource �� Path��%�   &	        '�� 7     �� .R�]� ��. .+��� 
���  ��$��1q�._��� �� " �� P�  �@=�HasError . . ��� 	 �@�ToolTip
 �� # Z $) #(Validation.Errors)[0].ErrorContent�.��� $	��416��$	��Top=�  	GridStyle#���   � RowDefinitions �� $	��28* ��� $
��215* ��� $
��173* � � ColumnDefinitions �� $
��625* ��� $
��136* �.+��� $��ĐỘC GIẢ��$
��Left=�$��
345,-2,0,0q�$	��Top=�$	��120��$
��Bold"�$��Times New Roman)�$��24(� J� RenderTransformOrigin$ 0.491,0.389&�$��38��$��2��
���  ���� $��
Thông tin��$
��Left=�$	��Top=�$	��614��$	��209��$��1��$ 0.5,0.5&�$��9,0,0,0q�z�V� .~��� ��  �� AngleY$ 0.203Q��� T�  T� Y$ 0.496Q�.��� $
��Left=�$	��193��$��	0,0,-2,-6q�$	��Top=�$	��604�� �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��	Họ Tên��$
��Left=�$��25��$	��Top=�$��90��$��0,4,0,0q��� $��Loại Độc Giả��$
��Left=�$	��Top=�$��26��$��90��$��	316,6,0,0q��� -    ��Name$ txtTenDocGia��$
��Left=�$��23�� �� TextWrapping$
 Wrap=�$	��Top=�$	��188�� =� ErrorTemplate# [  $��	104,6,0,0q����� *HoTen+ �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ 	LostFocus=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . {��� *
IsEditable+�� $��
Ngày Sinh��$
��Left=�$��90��$��0,4,0,5q�$��1���� $��Địa Chỉ��$
��Left=�$	��Top=�$��26��$��90��$��1��$��	316,4,0,0q��� $��Email��$
��Left=�$	��Top=�$ -0.272,-1.352&�$��26��$��90��$��2��$��	316,2,0,0q��� $��Ngày lập thẻ��$
��Left=�$��2��$	��Top=�$��90��$��0,2,0,0q��� $��Ngày hết hạn��$��Right=�$��3��$	��Top=�$��	0,2,514,0q�$��90���� -   $ 	txtDiaChi��$
��Left=�$��23��$��	406,4,0,0q�$��1��$
 Wrap=�# [  $	��Top=�$	��188������ *DiaChi+$ TwoWay=� . $ 	LostFocus=� .  . {��� *
IsEditable+�� -   $ txtEmail��$
��Left=�$��23��$��	406,5,0,0q�$��2��$
 Wrap=�# [  $	��Top=�$	��188������ *Email+$ TwoWay=� . $ 	LostFocus=� .  . {��� *
IsEditable+(  "System.Windows.Controls.DatePicker  -     Name$ dateNgaySinh��$
��Left=�$��	104,6,0,0q�$��1��$	��Top=�$	��188��|�.     SelectedDate �� *
NgaySinh+{��� *
IsEditable+  -   $ dateNgayLapThe��$
��Left=�$��	104,2,0,0q�$��2��$	��Top=�$	��188��|�.   �� *
NgayLapThe+{��� *
IsEditable+  -   $ dateNgayHetHan��$
��Left=�$��	104,3,0,0q�$��3��$	��Top=�$	��188��{�.   �� *
NgayHetHan+�� -    ��Name$ cbLoaiDocGia��$
��Left=�$	��Top=�$	��188��$��	406,7,0,0q� �� DisplayMemberPath$ TenLoaiDocGia������ *ListLoaiDocGia+ �� SelectedItem �� *SelectedLoaiDocGia+$ TwoWay=�{��� *
IsEditable+�� $��1��$��Điều khiển��$
��Left=�$��	10,10,0,0q�$��1��$	��Top=�$	��117��$	��202��.��� $
��Left=�$	��183��$	��Top=�$	��107��$��	0,0,-2,-3q� �� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* �.+��� $
��Lưu��$
��Left=�$��10,9,0,0q�$	��Top=�$��87��$��27��$��1��  ButtonStyle#���  ���� *SaveCommand+{��� *	CanSave+�� $��Thêm mới��$
��Left=�$��	10,10,0,0q�$	��Top=�$��87��$��27��#���  ���� *
AddCommand+�� -   $��btThoat��$��Thoát��$
��Left=�$��10,5,0,0q�$��4��$	��Top=�$��87��$��29��#���  �� $��Sửa��$
��Left=�$��10,7,0,0q�$��2��$	��Top=�$��87��$��30��#���  ���� *EditCommand+�� $
��Xóa��$
��Left=�$��10,6,0,0q�$��3��$	��Top=�$��87��$��30��#���  ���� *RemoveCommand+�� $��Danh sách đôc giả��$��2��$	��Top=�$��2��$	��163��$
��10,0q�.��&   System.Windows.Controls.DataGrid  $
��Left=�$��
0,10,-2,-2q�$	��Top=�$	��133��$	��733��    AutoGenerateColumns  .  !   
IsReadOnly! . ���� *
ListDocGia+ �� *SelectedDocGia+$ TwoWay=�"   Columns" 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn#   Header$# Mã độc giả��$   Width5  /System.Windows.Controls.DataGridLengthConverter$$ 70 1  +System.Windows.Controls.DataGridBoundColumn%   Binding% �� *
MaDocGia+$ TwoWay=�$ PropertyChanged=�  $# Tên độc giả��$$ 90 % �� *HoTen+$ TwoWay=�$ PropertyChanged=�  $# Loại độc giả��$$ 80 % �� *LoaiDocGia.TenLoaiDocGia+$ TwoWay=�$ PropertyChanged=�  $# 
Ngày sinh��$$ 80 % �� *
NgaySinh+$ TwoWay=�$ PropertyChanged=�  $# Địa chỉ��$$ 90 % �� *DiaChi+$ TwoWay=�$ PropertyChanged=�  $# Email��$$ 90 % �� *Email+$ TwoWay=�$ PropertyChanged=�  $# Ngày lập thẻ��$$ 80 % �� *
NgayLapThe+$ TwoWay=�$ PropertyChanged=�  $# Ngày hết hạn��$$ 80 % �� *
NgayHetHan+$ TwoWay=�$ PropertyChanged=�  $# Tổng nợ��$$ 70 % �� *TongNo+$ TwoWay=�$ PropertyChanged=�