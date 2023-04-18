using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExerciseOnClasses1 {
    public class InvoiceItem {
        private string id;
        private string desc;
        private int qty;
        private double unitPrice;
        public InvoiceItem(string id, string desc, int qty, double unitPrice) {
            this.id = id;
            this.desc = desc;
            this.qty = qty;
            this.unitPrice = unitPrice;
        }
        public string getID() {
            return id;
        }
        public string getDesc() {
            return desc;
        }
        public int getQty() {
            return qty;
        }
        public void setQty(int qty) {
            this.qty = qty;
        }
        public double getUnitPrice() {
            return unitPrice;
        }
        public void setUnitPrice(double unitPrice) {
            this.unitPrice = unitPrice;
        }
        public double getTotal() {
            return qty*unitPrice;
        }
        public override string ToString() {
            return $"InvoiceItem[id={id},desc={desc},qty={qty},unitPrice={unitPrice}]";
        }
    }
}
