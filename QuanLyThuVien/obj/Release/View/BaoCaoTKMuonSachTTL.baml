   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  /    )QuanLyThuVien.Screens.BaoCaoTKMuonSachTTL   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$;  5BÁO CÁO THỐNG KÊ MƯỢN SÁCH THEO THỂ LOẠI��$	��300��$��606.8�� � 
ResizeMode$ CanMinimize=� � Icon$4 ./QuanLyThuVien;component/Resources/bao cao.png�� � DataContext 3  -QuanLyThuVien.TheBCTKMuonSachTheoTheLoaiModel   � 	Resources    ErrorTemplate �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� Self �� RelativeSource �� Path��%�   &	        '�� 7     �� .R�]� ��. .+��� 
���  ��$��1q�._��� �� " �� P�  �@=�HasError . . ��� 	 �@�ToolTip
 �� # Z $) #(Validation.Errors)[0].ErrorContent�.���   	GridStyle#���   � RowDefinitions �� $
��100* ��� $
��169* � � ColumnDefinitions �� $
��456* ��� $
��143* �.+��� $��Thông tin báo cáo��$
��Left=�$	��Top=�$	��436��$��92��$��10,0,0,0q�.��� $
��Left=�$��61��$	��Top=�$	��426��$��0,9,-2,0q� �� $	��39* ��� $	��34* � �� $	��40* ��� $	��31* �.+��� $��Tháng báo cáo��$
��Left=�$��1,4,0,0q�$	��Top=�$��26��$��88���� $
��Left=�$��23��$��94,7,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��83�� =� ErrorTemplate# [  ���� *Thang+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ 	LostFocus=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . �� $
��Left=�$��14��$��10,4,0,0q�$��1��$
��Wrap=�$
��Năm��$	��Top=�$��59���� $
��Left=�$��22��$��93,2,0,0q�$��1��$
 Wrap=�$	��Top=�$��84������ *Year+�� $��1��$��Điều khiển��$
��Left=�$	��Top=�$	��133��$	��233��$��2��.��� $
��Left=�$	��211��$	��Top=�$	��123��$��0,0,-2,0q� �� $	��60* ��� $	��60* ��� $	��60* �.+��� $��Thống kê��$
��Left=�$��	10,19,0,0q�$	��Top=�$	��103��$��41��  ButtonStyle#���  $��16(����� *ActionCommand+�� -    ��Name$ btThoat��$��Thoát��$
��Left=�$��	10,20,0,0q�$��2��$	��Top=�$	��103��$��41��#���  $��16(��� $��
Danh sách��$
��Left=�$��1��$	��Top=�$	��436��$	��133��$��10,0,0,0q�.��&   System.Windows.Controls.DataGrid  $
��Left=�$��	0,10,-2,0q�$	��Top=�$	��100��$	��426��   AutoGenerateColumns .  ���� *
ListBCct+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Tên thể loại��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *LoaiSach.TenLoaiSach+  $ Số lượt mượn��$ 90  �� *SoLuot+  $ 	Tỉ lệ��$ 60  �� *TiLe+�� $!��Tổng số lượt mượn��$
��Left=�$��144,133,0,0q�$��1��$	��Top=�$	��140��$��28��$
��Bold"�$��14(����	#FFDC0D0D�� $
��Left=�$��23��$��289,138,0,0q�$��1��$
 Wrap=�$	��Top=�$	��157��{�.  ���� *TongSo+