# TadosTest

Simple CRUD application using WCF service and WinForms client.

#### ��������
���������� ������� �� ��� ��������: ������, ������ � �������� WCF �������.
������ - self-hosted WCF service, SQL DataBase + SQL Command
������ ��������� � �������� �������: 
	- � ����� ������� ������ � ��� �������;
	- � ������ �������� ������ (��).

������ - WinForms, MVP.

![image](/Pictures/MainForm.png)

#### ���������� ����

![image](/Pictures/IdealStructure.png)

������ � ��������� ����

![image](/Pictures/IdealRequest.png)


#### ������� �������

![image](/Pictures/CurrentStructure.png)

���� �������

![image](/Pictures/CurrentRequest.png)

#### ���������� �������� �������

- ��� ��������� ������ �� ������� �������. ��� ��������� ������. 
- ���� ���������� �� ����� ����� (View).
- ���������� ���������� ��������� ������� �� �������. ������ ������, ��� �������� ������ - ��, ��������� � �� ����� � ���������� ����.
- ������� ����������� Presenter � ClientProxy.
- �� �������� �����.
- ������ �� ����������, ���� ��� ���������� � ��������.