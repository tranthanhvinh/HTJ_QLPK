using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Bus_Sequence
    {
        QLPKEntities db = null;
        public Bus_Sequence()
        {
            db = new QLPKEntities();
        }
        public Sequence getItem(string seqname)
        {
            return db.Sequences.FirstOrDefault(x => x.Seqname == seqname);
        }
        public void add(Sequence sequence)
        {
            try
            {
                db.Sequences.Add(sequence);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void update(Sequence sequence)
        {
            var seq = db.Sequences.FirstOrDefault(x => x.Seqname == sequence.Seqname);
            seq.Seqvalue = sequence.Seqvalue + 1;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
