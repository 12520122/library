   M S B A M L   `   `   `  ���� H  DQuanLyThuVien, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyThuVienQuanLyThuVien  "    QuanLyThuVien.ThayDoiQuyDinh   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -localclr-namespace:QuanLyThuVien       � Title$  THAY ĐỔI QUY ĐỊNH��$	��404��$��464.9�� � 
ResizeMode$ CanMinimize=� � DataContext &   QuanLyThuVien.TheThamSoViewModel  .��� $��0,0,0,5q�   	GridStyle#���    � RowDefinitions �� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* ��� $	��36* � � ColumnDefinitions �� $
��254* ��� $	��89* ��� $
��114* �.+��� $��THAY ĐỔI QUY ĐỊNH��$
��Left=�$��	100,0,0,0q�$	��Top=�$	��260��$��3��$��Times New Roman)�$��24(�$
��Bold"�$��36�����	#FFF70404�� $ ��Độ tuổi tối thiểu��$
��Left=�$��10,0,0,0q�$��2��$	��Top=�$��18(�$��34��$	��140���� $��Độ tuổi tối đa��$
��Left=�$��10,3,0,0q�$��3��$	��Top=�$��18(�$��34��$	��120���� $$��Số tháng thời hạn thẻ��$
��Left=�$��10,0,0,0q�$��4��$	��Top=�$��18(�$��34���� $)��#Số năm thời hạn xuất bản��$
��Left=�$��10,1,0,0q�$��5��$	��Top=�$��18(�$��34��$	��225���� $"��Số sách mượn tối đa��$
��Left=�$��12,0,0,0q�$��6��$	��Top=�$��36��$	��187��$��18(��� $"��Số ngày mượn tối đa��$
��Left=�$��12,0,0,0q�$��7��$	��Top=�$��37��$	��189��$��18(�$��2���� $��1��$
��Left=�$��30��$��10,0,0,0q�$��2�� �� TextWrapping$
 Wrap=�$	��Top=�$��71��$��18(� �� TextAlignment$ Center=� �� TextDecorations Z� ���� *TuoiDocGiaToiThieu+�� $��1��$
��Left=�$��32��$��10,0,0,0q�$��3��$
 Wrap=�$	��Top=�$��71��$��18(�$ Center=����� *TuoiDocGiaToiDa+�� $��1��$
��Left=�$��30��$��10,0,0,0q�$��4��$
 Wrap=�$	��Top=�$��71��$��18(�$ Center=����� *SoThangThoiHanThe+�� $��1��$
��Left=�$��10,0,0,0q�$��5��$
 Wrap=�$��71��$��18(�$ Center=�$��32��$	��Top=����� *SoNamThoiHanXuatBan+�� $��1��$
��Left=�$��33��$��10,1,0,0q�$��6��$
 Wrap=�$	��Top=�$��71��$��18(�$ Center=����� *SoSachMuonToiDa+�� $��1��$
��Left=�$��33��$��10,0,0,0q�$��7��$
 Wrap=�$	��Top=�$��71��$��18(�$ Center=�$��2������ *SoNgayMuonToiDa+�� $��
Giá trị��$��1��$
��Left=�$��10,0,0,0q�$��1��$	��Top=�$��36��$��71��$��18(�$
��Bold"��� $��2��$��Điều khiển��$
��Left=�$��1��$	��Top=�$	��104��$	��175��$��5��$��0,10,0,0q�$��14(�.��� $
��Left=�$	��136��$��
-10,0,-2,0q�$	��Top=�$	��104�� �� $	��60* ��� $	��60* �.+��� $��Thay đổi��$
��Left=�$��	16,10,0,0q�$	��Top=�$��78��$��18(�  ButtonStyle#���  ���� *SaveCommand+�� -   $��Thoát��$
��Left=�$��	16,10,0,0q�$��1��$	��Top=�$��78��$��18(�#���  �� $��Quy định��$
��Left=�$��12,1,0,0q�$��1��$	��Top=�$	��171��$��18(�$
��Bold"�$��34���� -   $��
btLoaiSach��$��Thay đổi loại sách��$
��Left=�$��24,0,0,0q�$��8��$	��Top=�$	��177��$��18(�#���  $��41���� -   $��btLoaiDocGia��$��2��$%��Thay đổi loại độc giả��$��1��$
��Left=�$��10,0,0,0q�$��8��$	��Top=�$	��183��$��18(�$��41��#���  