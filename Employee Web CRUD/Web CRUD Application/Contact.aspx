<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web_CRUD_Application.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
   

    <div className="Contact-box" id="Contact">
      <div className="Contact container">
        <div className="row map"></div>
        <div className="row content position-relative">
          <h1 className="text-warning ">Contact Us</h1>
          <p className="text-center ">
            Contact us and lets decide how we can assisst you
          </p>
        </div>
        <div className="row container">
          <div className="contact-info p-5 col-lg-6 col-md-6 col-sm-12 col-xsm-12 position-relative">
            <div>
              
              <strong>Phone</strong>
              <p className="mt-1">123456789</p>
            </div>
            <div>
              
              <strong>Email</strong>
              <p className="mt-1">abc@gmail.com</p>
            </div>
            <div>
             
              <strong>Address</strong>
              <p className="mt-1">
                 One Microsoft Way<br />
        Redmond, WA 98052-6399
              </p>
            </div>
          </div>
          <div className="contact-form col-lg-6 col-md-6 col-sm-12 col-xsm-12 position-relative">
            <form onSubmit={sendEmail}>
              <div className="mb-3">
                <label className="form-label">Full Name</label>
                <input
                  type="text"
                  placeholder="Your Name"
                  className="form-control"
                  name="name"
                />
                <br />
                <label className="form-label">Email Address</label>
                <input
                  type="Email"
                  placeholder="Your Email"
                  className="form-control"
                  id="exampleInputEmail1"
                  aria-describedby="emailHelp"
                  name="user_email"
                />
                <div id="emailHelp" className="form-text">
                  We'll never share your email with anyone else.
                </div>
                <textarea
                  name="message"
                  className="form-control mt-2"
                  placeholder="Type your message here..."
                  rows="5"
                ></textarea>
              </div>
              <button type="submit" className="btn btn btn-outline-warning">
                Submit
              </button>
            </form>
          </div>
        </div>
      </div>
    </div>








</asp:Content>
