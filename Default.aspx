<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">



        .style1
        {
            font-size: 25pt;
        }
        .style2
        {
            font-size: 15pt;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    
        <br />
        &nbsp;<span class="style1">Inclusão - Alteração - Exclusão de Dados com LINQ TO SQL 
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="LinqDataSource1" Font-Size="Medium" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="NOME" HeaderText="NOME" SortExpression="NOME" />
                <asp:BoundField DataField="RUA" HeaderText="RUA" SortExpression="RUA" />
                <asp:BoundField DataField="BAIRRO" HeaderText="BAIRRO" SortExpression="BAIRRO" />
                <asp:BoundField DataField="CIDADE" HeaderText="CIDADE" SortExpression="CIDADE" />
                <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" SortExpression="ESTADO" />
                <asp:BoundField DataField="DATA_ENTRADA" HeaderText="DATA_ENTRADA" SortExpression="DATA_ENTRADA" />
                <asp:BoundField DataField="DATA_SAIDA" HeaderText="DATA_SAIDA" SortExpression="DATA_SAIDA" />
                <asp:BoundField DataField="QUARTO" HeaderText="QUARTO" SortExpression="QUARTO" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server" CellPadding="4" Font-Size="Medium" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="trab_marquimDataContext" EntityTypeName="" OrderBy="NOME" TableName="PESSOAs">
        </asp:LinqDataSource>
        <br />
        Filtro:</span><asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Buscar" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Inclusão" />
        &nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Edição" />
        &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Deleção" />
        <br />
        <br />
        <asp:Label ID="lbID" runat="server"></asp:Label>
        <br />
        <br />
        Nome:
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        Rua:
        <asp:TextBox ID="txtRua" runat="server"></asp:TextBox>
        <br />
        Bairro:
        <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
        <br />
        Cidade:
        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
        <br />
        Estado:
        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        <br />
        Data Entrada:<asp:TextBox ID="txtDtEntrada" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        Data Saída:<asp:TextBox ID="txtDtSaida" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        Quarto:<asp:TextBox ID="txtQuarto" runat="server"></asp:TextBox>
        <br />
    
    </div>
    
    </div>
    </form>
</body>
</html>
