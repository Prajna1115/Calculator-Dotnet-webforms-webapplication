<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StandardControls.aspx.cs" Inherits="WebFormsExamples.StandardControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-2">
            <table style="width: 50%;" class="table">
                <tr>
                    <td colspan="3">
                        <asp:TextBox ID="txtVal" runat="server"></asp:TextBox>
                        <asp:Label ID="lblOp" runat="server" Text="Label"></asp:Label>
                        
                        <asp:TextBox ID="txtVal2" runat="server" class="no-outline"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                   
                    <td>
                        <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" /></td>
                    <td>
                        <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click" /></td>
                    <td>
                        <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click" /></td>
                 <td>
                     <asp:Button ID="btnPlus" runat="server" Text="+" OnClick="btnPlus_Click1" />
                 </td>

                    <tr>
                    <td>
                        <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click" /></td>
                    <td>
                        <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click" /></td>
                    <td>
                        <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click" /></td>
                        <td>
                            <asp:Button ID="btnMinus" runat="server" Text="-" OnClick="btnMinus_Click1" />
                        </td>


                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click" /></td>
                            <td>
                                <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click" /></td>
                        <td>
                            <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnDivision" runat="server" Text="/" OnClick="btnDivision_Click1" />
                        </td>
                </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnComma" runat="server" Text="," OnClick="btnComma_Click" />
                        </td>
                        <td>
                        <asp:Button ID="btn0" runat="server" Text="0" OnClick="btn0_Click" /></td>
                        <td>
                    <asp:Button ID="btnMultiply" runat="server" Text="*" OnClick="btnMultiply_Click1" /></td>
                        <td>
                            <asp:Button ID="btnEqual" runat="server" Text="=" OnClick="btnEqual_Click1" />
                        </td>
                        </tr>
                    
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
               
                       
                     
                    <td>&nbsp;</td>
                    
                    
                </tr>
              
            </table>
    </div>
  

    </div>
</asp:Content>


