   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  &     QuanLyThuVien.BaoCaoTKSachTraTre   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$-  'BÁO CÁO THỐNG KÊ SÁCH TRẢ TRỄ��$	��248��$��564.8�� � 
ResizeMode$ CanMinimize=� � Icon$4 ./QuanLyThuVien;component/Resources/bao cao.png�� � DataContext +  %QuanLyThuVien.BCTKSachTraTreViewModel   � 	Resources    ErrorTemplate �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� Self �� RelativeSource �� Path��%�   &	        '�� 7     �� .R�]� ��. .+��� 
���  ��$��1q�._��� �� " �� P�  �@=�HasError . . ��� 	 �@�ToolTip
 �� # Z $) #(Validation.Errors)[0].ErrorContent�.���   	GridStyle#���   � RowDefinitions �� $	��73* ��� $
��144* � � ColumnDefinitions �� $
��166* ��� $	��67* �.+��� $��Thông tin báo cáo��$
��Left=�$	��Top=�$	��388��$��63��$��10,0,0,0q�.��� $
��Left=�$��44��$��	0,0,-2,-3q�$	��Top=�$	��367�� �� $
��183* ��� $
��184* �.+��� $��Ngày báo cáo��$
��Left=�$��	53,10,0,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��
165,11,0,0q�$	��Top=�$	��116��{�. $��2��   SelectedDate �� *
NgayBaoCao+�� $��1��$��Điều khiển��$
��Left=�$��10,0,0,0q�$	��Top=�$	��140��$	��207��$��2��.��� $
��Left=�$	��184��$	��Top=�$	��130��$��0,0,-2,0q� �� $	��60* ��� $	��60* ��� $	��60* �.+��� -   $��btLuuBC��$��Thống kê��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��110��$��41��  ButtonStyle#���  ���� *ActionCommand+�� -   $��btThoat��$��Thoát��$
��Left=�$��	10,10,0,0q�$��2��$	��Top=�$	��110��$��41��#���  �� $��
Danh sách��$
��Left=�$��	10,68,0,0q�$	��Top=�$��2��$	��388��$	��139��.��&   System.Windows.Controls.DataGrid  $
��Left=�$��
0,10,-2,-1q�$	��Top=�$	��108��$	��378��   AutoGenerateColumns .  ���� *
ListTraTre+ �� Mode$ TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Tên sách��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *CuonSach.DauSach.TenDauSach+  $ Ngày mượn��$ 72  �� *
NgayMuon+  $ Số ngày trả trễ��$	 100  �� *SoNgayTraTre+