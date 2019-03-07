using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DummyProjectSM.Models;

namespace DummyProjectSM.Tests.Models
{
    [TestClass]
    public class PostModelTest
    {
        //IsValid Start
        [TestMethod]
        public void IsValidTrueTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsTrue(P.IsValid());
        }
        [TestMethod]
        public void IsValidFalseFromTitleTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "I am going to go over 100 characters in this title so that I can make this title fail 88 91 94 97 101", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsFalse(P.IsValid());
        }
        [TestMethod]
        public void IsValidFalseFromTextTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "asdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaos3004", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsFalse(P.IsValid());
        }
        [TestMethod]
        public void IsValidFalseFromPostURLTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "ado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0ooo503", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsFalse(P.IsValid());
        }
        [TestMethod]
        public void IsValidFalseFromImageURLTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.ado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0ooo503.com/helloImage/9444981148", IsVideo = false };

            Assert.IsFalse(P.IsValid());
        }
        //IsValid End

        //Individuals PostModels Start
        [TestMethod]
        public void TitleUnderLimitTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsTrue(P.IsUnderTitleLimit());
        }
        [TestMethod]
        public void PostURLUnderLimitTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsTrue(P.IsUnderPostURLLimit());
        }
        [TestMethod]
        public void ImageURLUnderLimitTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsTrue(P.IsUnderImageURLLimit());
        }
        [TestMethod]
        public void TextUnderLimitTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsTrue(P.IsUnderTextLimit());
        }
        //
        //
        //

        [TestMethod]
        public void TitleOverLimitTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "I am going to go over 100 characters in this title so that I can make this title fail 88 91 94 97 101", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsFalse(P.IsUnderTitleLimit());
        }
        [TestMethod]
        public void PostURLOverLimitTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "ado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0ooo503", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsFalse(P.IsUnderPostURLLimit());
        }
        [TestMethod]
        public void ImageURLOverLimitTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "Hello", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.ado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0ooo503.com/helloImage/9444981148", IsVideo = false };

            Assert.IsFalse(P.IsUnderImageURLLimit());
        }
        [TestMethod]
        public void TextOverLimitTest()
        {
            PostModel P = new PostModel() { PostID = 0, PostTitle = "HiTitle", PostText = "asdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaos3004", PostURL = "Something.something.com/something/32949848", PostImageURL = "Something.something.com/helloImage/9444981148", IsVideo = false };

            Assert.IsFalse(P.IsUnderTextLimit());
        }
        //Individuals PostModels End

        //Individuals String Test Start
        [TestMethod]
        public void StringTitleUnderLimitTest()
        {
            String P = "HiTitle";

            Assert.IsTrue(PostModel.IsUnderTitleLimit(P));
        }
        [TestMethod]
        public void StringPostURLUnderLimitTest()
        {
            String P = "Something.something.com/something/32949848";
            Assert.IsTrue(PostModel.IsUnderPostURLLimit(P));
        }
        [TestMethod]
        public void StringImageURLUnderLimitTest()
        {
            String P = "Something.something.com/helloImage/9444981148";
            Assert.IsTrue(PostModel.IsUnderImageURLLimit(P));
        }
        [TestMethod]
        public void StringTextUnderLimitTest()
        {
            String P = "Hello";
            Assert.IsTrue(PostModel.IsUnderTextLimit(P));
        }

        //
        //


        [TestMethod]
        public void StringTitleOverLimitTest()
        {
            String P = "I am going to go over 100 characters in this title so that I can make this title fail 88 91 94 97 101";

            Assert.IsFalse(PostModel.IsUnderTitleLimit(P));
        }
        [TestMethod]
        public void StringPostURLOverLimitTest()
        {
            String P = "ado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0ooo503";
            Assert.IsFalse(PostModel.IsUnderPostURLLimit(P));
        }
        [TestMethod]
        public void StringImageURLOverLimitTest()
        {
            String P = "ado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0oooado;kfnaovinpeoifnapiodsnvpzinrpaviunpwdsiguvnpaw9uienfvpazuicvnbpoasuindvpaifndspaooiksnpodfino0ooo503";
            Assert.IsFalse(PostModel.IsUnderImageURLLimit(P));
        }
        [TestMethod]
        public void StringTextOverLimitTest()
        {
            String P = "asdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaosasdfasdkfja;oidnoianewpovianosidjfpaoidsjfpoiasjdfpoiajspd;oifpaosidnvpioanwepoiansdpvoinapiodnvoaos3004";
            Assert.IsFalse(PostModel.IsUnderTextLimit(P));
        }

        //Individuals String Test End
    }
}
