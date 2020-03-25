Public Class Form1
    Private Sub عقود_البيعBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.عقود_البيعBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub عقود_البيعBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.عقود_البيعBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub عقود_البيعBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles عقود_البيعBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.عقود_البيعBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.فواتير_بيع' table. You can move, or remove it, as needed.
        Me.فواتير_بيعTableAdapter.Fill(Me.DatabaseDataSet.فواتير_بيع)
        'TODO: This line of code loads data into the 'DatabaseDataSet.فواتير_الشراء' table. You can move, or remove it, as needed.
        Me.فواتير_الشراءTableAdapter.Fill(Me.DatabaseDataSet.فواتير_الشراء)
        'TODO: This line of code loads data into the 'DatabaseDataSet.عملاء' table. You can move, or remove it, as needed.
        Me.عملاءTableAdapter.Fill(Me.DatabaseDataSet.عملاء)
        'TODO: This line of code loads data into the 'DatabaseDataSet.عقود_شراء' table. You can move, or remove it, as needed.
        Me.عقود_شراءTableAdapter.Fill(Me.DatabaseDataSet.عقود_شراء)
        'TODO: This line of code loads data into the 'DatabaseDataSet.سيارات' table. You can move, or remove it, as needed.
        Me.سياراتTableAdapter.Fill(Me.DatabaseDataSet.سيارات)
        'TODO: This line of code loads data into the 'DatabaseDataSet.الموردين' table. You can move, or remove it, as needed.
        Me.الموردينTableAdapter.Fill(Me.DatabaseDataSet.الموردين)
        'TODO: This line of code loads data into the 'DatabaseDataSet.الموردين' table. You can move, or remove it, as needed.
        Me.الموردينTableAdapter.Fill(Me.DatabaseDataSet.الموردين)
        'TODO: This line of code loads data into the 'DatabaseDataSet.عقود_البيع' table. You can move, or remove it, as needed.
        Me.عقود_البيعTableAdapter.Fill(Me.DatabaseDataSet.عقود_البيع)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.عقود_البيعBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.عقود_البيعBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.عقود_البيعBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.الموردينBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Validate()
        Me.الموردينBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.الموردينBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.سياراتBindingSource.AddNew()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Validate()
        Me.سياراتBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.سياراتBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.عقود_شراءBindingSource.AddNew()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Validate()
        Me.عقود_شراءBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.عقود_شراءBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.عملاءBindingSource.AddNew()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Validate()
        Me.عملاءBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.عملاءBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.فواتير_الشراءBindingSource.AddNew()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Validate()
        Me.فواتير_الشراءBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.فواتير_الشراءBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Me.فواتير_بيعBindingSource.AddNew()

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Validate()
        Me.فواتير_بيعBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet
                                         )
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Me.فواتير_بيعBindingSource.RemoveCurrent()

    End Sub
End Class
