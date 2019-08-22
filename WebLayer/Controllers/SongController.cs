﻿using DataManager.DataAccess;
using SharedModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLayer.Controllers
{
    public class SongController : Controller
    {
        // GET: Song
        public ActionResult Index()
        {
            return View();
        }

        // GET: Song/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Song/Create
        public ActionResult Create(int savedCdId)
        {
            return View();
        }

        // POST: Song/Create
        [HttpPost]
        public ActionResult Create(SongModel song, int savedCdId)
        {
            try
            {
                song.CdId = savedCdId;
                SongData.SaveSong(song);

                return RedirectToAction("Create", new { savedCdId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Song/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Song/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Song/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Song/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
