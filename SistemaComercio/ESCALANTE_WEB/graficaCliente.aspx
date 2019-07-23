<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="graficaCliente.aspx.cs" Inherits="ESCALANTE_WEB.graficaCliente" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>


    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
            <asp:Chart ID="Cuadroclientes" runat="server" OnLoad="Cuadroclientes_Load">
                <Series>
                    <asp:Series Name="Series1"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </asp:Content>
