<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Web_CRUD_Application.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div className="About container" id="About">
        <div className="About-content text-dark">
          <div className="row">
            <div className="About-text col-lg-6 col-md-12 col-sm-12">
              <h2 className="text-warning">Brief Company Introduction</h2>
              <p className="fst-italic">
                M.A. Kamil is Subsidiary of M. A. Kamil Group of Companies.
              </p>
              <p>
                We are involved in undermentioned sales and services activities
                from last four decades. We are Group of companies working in
                different fields under the chairmanship of{" "}
                <strong className="text-warning">MR. SHAHID KAMIL.</strong>
              </p>
              <ul>
                <li>
                  <i className="ri-check-double-line"></i> Sales of Pharma
                  Excipients / Raw materials
                </li>
                <li>
                  <i className="ri-check-double-line"></i> Sales of Cosmetics
                  Chemicals
                </li>
                <li>
                  <i className="ri-check-double-line"></i> Sales of Food Raw
                  Materials & Herbal Extracts
                </li>
                <li>
                  <i className="ri-check-double-line"></i> Feed Additives
                </li>
              </ul>
            </div>

            <div className="About-img col-lg-6 col-md-12 col-sm-12 ">
              <img src={About_img} />
            </div>
          </div>
        </div>
      </div>
</asp:Content>
