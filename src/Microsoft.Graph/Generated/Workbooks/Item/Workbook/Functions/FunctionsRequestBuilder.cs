using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Abs;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AccrInt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AccrIntM;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Acos;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Acosh;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Acot;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Acoth;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AmorDegrc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AmorLinc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.And;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Arabic;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Areas;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Asc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Asin;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Asinh;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Atan;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Atan2;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Atanh;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AveDev;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Average;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AverageA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AverageIf;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.AverageIfs;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.BahtText;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Base;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.BesselI;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.BesselJ;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.BesselK;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.BesselY;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Beta_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Beta_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Bin2Dec;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Bin2Hex;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Bin2Oct;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Binom_Dist_Range;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Binom_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Binom_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Bitand;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Bitlshift;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Bitor;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Bitrshift;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Bitxor;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Ceiling_Math;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Ceiling_Precise;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Char;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ChiSq_Dist_RT;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ChiSq_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ChiSq_Inv_RT;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ChiSq_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Choose;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Clean;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Code;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Columns;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Combin;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Combina;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Complex;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Concatenate;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Confidence_Norm;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Confidence_T;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Convert;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Cos;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Cosh;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Cot;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Coth;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Count;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CountA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CountBlank;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CountIf;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CountIfs;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CoupDayBs;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CoupDays;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CoupDaysNc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CoupNcd;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CoupNum;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CoupPcd;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Csc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Csch;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CumIPmt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.CumPrinc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Date;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Datevalue;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Daverage;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Day;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Days;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Days360;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Db;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dbcs;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dcount;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.DcountA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Ddb;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dec2Bin;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dec2Hex;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dec2Oct;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Decimal;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Degrees;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Delta;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.DevSq;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dget;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Disc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dmax;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dmin;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dollar;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.DollarDe;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.DollarFr;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dproduct;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.DstDev;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.DstDevP;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dsum;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Duration;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Dvar;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.DvarP;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Ecma_Ceiling;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Edate;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Effect;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.EoMonth;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Erf_Precise;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Erf;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ErfC_Precise;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ErfC;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Error_Type;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Even;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Exact;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Exp;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Expon_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.F_Dist_RT;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.F_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.F_Inv_RT;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.F_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Fact;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.FactDouble;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.False;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Find;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.FindB;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Fisher;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.FisherInv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Fixed;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Floor_Math;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Floor_Precise;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Fv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Fvschedule;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Gamma_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Gamma_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Gamma;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.GammaLn_Precise;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.GammaLn;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Gauss;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Gcd;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.GeoMean;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.GeStep;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.HarMean;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Hex2Bin;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Hex2Dec;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Hex2Oct;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Hlookup;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Hour;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Hyperlink;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.HypGeom_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.If;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImAbs;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Imaginary;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImArgument;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImConjugate;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImCos;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImCosh;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImCot;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImCsc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImCsch;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImDiv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImExp;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImLn;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImLog10;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImLog2;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImPower;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImProduct;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImReal;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImSec;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImSech;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImSin;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImSinh;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImSqrt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImSub;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImSum;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ImTan;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Int;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IntRate;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Ipmt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Irr;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsErr;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsError;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsEven;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsFormula;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsLogical;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsNA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsNonText;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsNumber;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Iso_Ceiling;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsOdd;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsoWeekNum;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Ispmt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Isref;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.IsText;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Kurt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Large;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Lcm;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Left;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Leftb;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Len;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Lenb;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Ln;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Log;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Log10;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.LogNorm_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.LogNorm_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Lookup;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Lower;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Match;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Max;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.MaxA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Mduration;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Median;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Mid;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Midb;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Min;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.MinA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Minute;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Mirr;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Mod;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Month;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Mround;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.MultiNomial;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.N;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Na;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.NegBinom_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.NetworkDays_Intl;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.NetworkDays;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Nominal;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Norm_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Norm_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Norm_S_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Norm_S_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Not;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Now;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Nper;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Npv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.NumberValue;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Oct2Bin;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Oct2Dec;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Oct2Hex;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Odd;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.OddFPrice;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.OddFYield;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.OddLPrice;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.OddLYield;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Or;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Pduration;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Percentile_Exc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Percentile_Inc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.PercentRank_Exc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.PercentRank_Inc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Permut;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Permutationa;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Phi;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Pi;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Pmt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Poisson_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Power;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Ppmt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Price;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.PriceDisc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.PriceMat;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Product;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Proper;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Pv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Quartile_Exc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Quartile_Inc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Quotient;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Radians;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Rand;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.RandBetween;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Rank_Avg;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Rank_Eq;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Rate;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Received;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Replace;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.ReplaceB;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Rept;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Right;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Rightb;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Roman;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Round;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.RoundDown;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.RoundUp;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Rows;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Rri;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sec;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sech;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Second;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.SeriesSum;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sheet;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sheets;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sign;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sin;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sinh;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Skew_p;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Skew;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sln;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Small;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sqrt;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.SqrtPi;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Standardize;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.StDev_P;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.StDev_S;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.StDevA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.StDevPA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Substitute;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Subtotal;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Sum;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.SumIf;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.SumIfs;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.SumSq;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Syd;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.T_Dist_2T;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.T_Dist_RT;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.T_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.T_Inv_2T;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.T_Inv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.T;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Tan;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Tanh;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.TbillEq;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.TbillPrice;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.TbillYield;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Text;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Time;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Timevalue;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Today;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Trim;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.TrimMean;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.True;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Trunc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Type;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Unichar;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Unicode;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Upper;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Usdollar;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Value;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Var_P;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Var_S;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.VarA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.VarPA;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Vdb;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Vlookup;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Weekday;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.WeekNum;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Weibull_Dist;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.WorkDay_Intl;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.WorkDay;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Xirr;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Xnpv;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Xor;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Year;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.YearFrac;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Yield;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.YieldDisc;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.YieldMat;
using MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions.Z_Test;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Workbooks.Item.Workbook.Functions {
    /// <summary>Builds and executes requests for operations under \workbooks\{driveItem-id}\workbook\functions</summary>
    public class FunctionsRequestBuilder {
        public AbsRequestBuilder Abs { get =>
            new AbsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AccrIntRequestBuilder AccrInt { get =>
            new AccrIntRequestBuilder(PathParameters, RequestAdapter);
        }
        public AccrIntMRequestBuilder AccrIntM { get =>
            new AccrIntMRequestBuilder(PathParameters, RequestAdapter);
        }
        public AcosRequestBuilder Acos { get =>
            new AcosRequestBuilder(PathParameters, RequestAdapter);
        }
        public AcoshRequestBuilder Acosh { get =>
            new AcoshRequestBuilder(PathParameters, RequestAdapter);
        }
        public AcotRequestBuilder Acot { get =>
            new AcotRequestBuilder(PathParameters, RequestAdapter);
        }
        public AcothRequestBuilder Acoth { get =>
            new AcothRequestBuilder(PathParameters, RequestAdapter);
        }
        public AmorDegrcRequestBuilder AmorDegrc { get =>
            new AmorDegrcRequestBuilder(PathParameters, RequestAdapter);
        }
        public AmorLincRequestBuilder AmorLinc { get =>
            new AmorLincRequestBuilder(PathParameters, RequestAdapter);
        }
        public AndRequestBuilder And { get =>
            new AndRequestBuilder(PathParameters, RequestAdapter);
        }
        public ArabicRequestBuilder Arabic { get =>
            new ArabicRequestBuilder(PathParameters, RequestAdapter);
        }
        public AreasRequestBuilder Areas { get =>
            new AreasRequestBuilder(PathParameters, RequestAdapter);
        }
        public AscRequestBuilder Asc { get =>
            new AscRequestBuilder(PathParameters, RequestAdapter);
        }
        public AsinRequestBuilder Asin { get =>
            new AsinRequestBuilder(PathParameters, RequestAdapter);
        }
        public AsinhRequestBuilder Asinh { get =>
            new AsinhRequestBuilder(PathParameters, RequestAdapter);
        }
        public AtanRequestBuilder Atan { get =>
            new AtanRequestBuilder(PathParameters, RequestAdapter);
        }
        public Atan2RequestBuilder Atan2 { get =>
            new Atan2RequestBuilder(PathParameters, RequestAdapter);
        }
        public AtanhRequestBuilder Atanh { get =>
            new AtanhRequestBuilder(PathParameters, RequestAdapter);
        }
        public AveDevRequestBuilder AveDev { get =>
            new AveDevRequestBuilder(PathParameters, RequestAdapter);
        }
        public AverageRequestBuilder Average { get =>
            new AverageRequestBuilder(PathParameters, RequestAdapter);
        }
        public AverageARequestBuilder AverageA { get =>
            new AverageARequestBuilder(PathParameters, RequestAdapter);
        }
        public AverageIfRequestBuilder AverageIf { get =>
            new AverageIfRequestBuilder(PathParameters, RequestAdapter);
        }
        public AverageIfsRequestBuilder AverageIfs { get =>
            new AverageIfsRequestBuilder(PathParameters, RequestAdapter);
        }
        public BahtTextRequestBuilder BahtText { get =>
            new BahtTextRequestBuilder(PathParameters, RequestAdapter);
        }
        public BaseRequestBuilder Base { get =>
            new BaseRequestBuilder(PathParameters, RequestAdapter);
        }
        public BesselIRequestBuilder BesselI { get =>
            new BesselIRequestBuilder(PathParameters, RequestAdapter);
        }
        public BesselJRequestBuilder BesselJ { get =>
            new BesselJRequestBuilder(PathParameters, RequestAdapter);
        }
        public BesselKRequestBuilder BesselK { get =>
            new BesselKRequestBuilder(PathParameters, RequestAdapter);
        }
        public BesselYRequestBuilder BesselY { get =>
            new BesselYRequestBuilder(PathParameters, RequestAdapter);
        }
        public Beta_DistRequestBuilder Beta_Dist { get =>
            new Beta_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public Beta_InvRequestBuilder Beta_Inv { get =>
            new Beta_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public Bin2DecRequestBuilder Bin2Dec { get =>
            new Bin2DecRequestBuilder(PathParameters, RequestAdapter);
        }
        public Bin2HexRequestBuilder Bin2Hex { get =>
            new Bin2HexRequestBuilder(PathParameters, RequestAdapter);
        }
        public Bin2OctRequestBuilder Bin2Oct { get =>
            new Bin2OctRequestBuilder(PathParameters, RequestAdapter);
        }
        public Binom_DistRequestBuilder Binom_Dist { get =>
            new Binom_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public Binom_Dist_RangeRequestBuilder Binom_Dist_Range { get =>
            new Binom_Dist_RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        public Binom_InvRequestBuilder Binom_Inv { get =>
            new Binom_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public BitandRequestBuilder Bitand { get =>
            new BitandRequestBuilder(PathParameters, RequestAdapter);
        }
        public BitlshiftRequestBuilder Bitlshift { get =>
            new BitlshiftRequestBuilder(PathParameters, RequestAdapter);
        }
        public BitorRequestBuilder Bitor { get =>
            new BitorRequestBuilder(PathParameters, RequestAdapter);
        }
        public BitrshiftRequestBuilder Bitrshift { get =>
            new BitrshiftRequestBuilder(PathParameters, RequestAdapter);
        }
        public BitxorRequestBuilder Bitxor { get =>
            new BitxorRequestBuilder(PathParameters, RequestAdapter);
        }
        public Ceiling_MathRequestBuilder Ceiling_Math { get =>
            new Ceiling_MathRequestBuilder(PathParameters, RequestAdapter);
        }
        public Ceiling_PreciseRequestBuilder Ceiling_Precise { get =>
            new Ceiling_PreciseRequestBuilder(PathParameters, RequestAdapter);
        }
        public CharRequestBuilder Char { get =>
            new CharRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChiSq_DistRequestBuilder ChiSq_Dist { get =>
            new ChiSq_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChiSq_Dist_RTRequestBuilder ChiSq_Dist_RT { get =>
            new ChiSq_Dist_RTRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChiSq_InvRequestBuilder ChiSq_Inv { get =>
            new ChiSq_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChiSq_Inv_RTRequestBuilder ChiSq_Inv_RT { get =>
            new ChiSq_Inv_RTRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChooseRequestBuilder Choose { get =>
            new ChooseRequestBuilder(PathParameters, RequestAdapter);
        }
        public CleanRequestBuilder Clean { get =>
            new CleanRequestBuilder(PathParameters, RequestAdapter);
        }
        public CodeRequestBuilder Code { get =>
            new CodeRequestBuilder(PathParameters, RequestAdapter);
        }
        public ColumnsRequestBuilder Columns { get =>
            new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CombinRequestBuilder Combin { get =>
            new CombinRequestBuilder(PathParameters, RequestAdapter);
        }
        public CombinaRequestBuilder Combina { get =>
            new CombinaRequestBuilder(PathParameters, RequestAdapter);
        }
        public ComplexRequestBuilder Complex { get =>
            new ComplexRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConcatenateRequestBuilder Concatenate { get =>
            new ConcatenateRequestBuilder(PathParameters, RequestAdapter);
        }
        public Confidence_NormRequestBuilder Confidence_Norm { get =>
            new Confidence_NormRequestBuilder(PathParameters, RequestAdapter);
        }
        public Confidence_TRequestBuilder Confidence_T { get =>
            new Confidence_TRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConvertRequestBuilder Convert { get =>
            new ConvertRequestBuilder(PathParameters, RequestAdapter);
        }
        public CosRequestBuilder Cos { get =>
            new CosRequestBuilder(PathParameters, RequestAdapter);
        }
        public CoshRequestBuilder Cosh { get =>
            new CoshRequestBuilder(PathParameters, RequestAdapter);
        }
        public CotRequestBuilder Cot { get =>
            new CotRequestBuilder(PathParameters, RequestAdapter);
        }
        public CothRequestBuilder Coth { get =>
            new CothRequestBuilder(PathParameters, RequestAdapter);
        }
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        public CountARequestBuilder CountA { get =>
            new CountARequestBuilder(PathParameters, RequestAdapter);
        }
        public CountBlankRequestBuilder CountBlank { get =>
            new CountBlankRequestBuilder(PathParameters, RequestAdapter);
        }
        public CountIfRequestBuilder CountIf { get =>
            new CountIfRequestBuilder(PathParameters, RequestAdapter);
        }
        public CountIfsRequestBuilder CountIfs { get =>
            new CountIfsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CoupDayBsRequestBuilder CoupDayBs { get =>
            new CoupDayBsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CoupDaysRequestBuilder CoupDays { get =>
            new CoupDaysRequestBuilder(PathParameters, RequestAdapter);
        }
        public CoupDaysNcRequestBuilder CoupDaysNc { get =>
            new CoupDaysNcRequestBuilder(PathParameters, RequestAdapter);
        }
        public CoupNcdRequestBuilder CoupNcd { get =>
            new CoupNcdRequestBuilder(PathParameters, RequestAdapter);
        }
        public CoupNumRequestBuilder CoupNum { get =>
            new CoupNumRequestBuilder(PathParameters, RequestAdapter);
        }
        public CoupPcdRequestBuilder CoupPcd { get =>
            new CoupPcdRequestBuilder(PathParameters, RequestAdapter);
        }
        public CscRequestBuilder Csc { get =>
            new CscRequestBuilder(PathParameters, RequestAdapter);
        }
        public CschRequestBuilder Csch { get =>
            new CschRequestBuilder(PathParameters, RequestAdapter);
        }
        public CumIPmtRequestBuilder CumIPmt { get =>
            new CumIPmtRequestBuilder(PathParameters, RequestAdapter);
        }
        public CumPrincRequestBuilder CumPrinc { get =>
            new CumPrincRequestBuilder(PathParameters, RequestAdapter);
        }
        public DateRequestBuilder Date { get =>
            new DateRequestBuilder(PathParameters, RequestAdapter);
        }
        public DatevalueRequestBuilder Datevalue { get =>
            new DatevalueRequestBuilder(PathParameters, RequestAdapter);
        }
        public DaverageRequestBuilder Daverage { get =>
            new DaverageRequestBuilder(PathParameters, RequestAdapter);
        }
        public DayRequestBuilder Day { get =>
            new DayRequestBuilder(PathParameters, RequestAdapter);
        }
        public DaysRequestBuilder Days { get =>
            new DaysRequestBuilder(PathParameters, RequestAdapter);
        }
        public Days360RequestBuilder Days360 { get =>
            new Days360RequestBuilder(PathParameters, RequestAdapter);
        }
        public DbRequestBuilder Db { get =>
            new DbRequestBuilder(PathParameters, RequestAdapter);
        }
        public DbcsRequestBuilder Dbcs { get =>
            new DbcsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DcountRequestBuilder Dcount { get =>
            new DcountRequestBuilder(PathParameters, RequestAdapter);
        }
        public DcountARequestBuilder DcountA { get =>
            new DcountARequestBuilder(PathParameters, RequestAdapter);
        }
        public DdbRequestBuilder Ddb { get =>
            new DdbRequestBuilder(PathParameters, RequestAdapter);
        }
        public Dec2BinRequestBuilder Dec2Bin { get =>
            new Dec2BinRequestBuilder(PathParameters, RequestAdapter);
        }
        public Dec2HexRequestBuilder Dec2Hex { get =>
            new Dec2HexRequestBuilder(PathParameters, RequestAdapter);
        }
        public Dec2OctRequestBuilder Dec2Oct { get =>
            new Dec2OctRequestBuilder(PathParameters, RequestAdapter);
        }
        public DecimalRequestBuilder Decimal { get =>
            new DecimalRequestBuilder(PathParameters, RequestAdapter);
        }
        public DegreesRequestBuilder Degrees { get =>
            new DegreesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeltaRequestBuilder Delta { get =>
            new DeltaRequestBuilder(PathParameters, RequestAdapter);
        }
        public DevSqRequestBuilder DevSq { get =>
            new DevSqRequestBuilder(PathParameters, RequestAdapter);
        }
        public DgetRequestBuilder Dget { get =>
            new DgetRequestBuilder(PathParameters, RequestAdapter);
        }
        public DiscRequestBuilder Disc { get =>
            new DiscRequestBuilder(PathParameters, RequestAdapter);
        }
        public DmaxRequestBuilder Dmax { get =>
            new DmaxRequestBuilder(PathParameters, RequestAdapter);
        }
        public DminRequestBuilder Dmin { get =>
            new DminRequestBuilder(PathParameters, RequestAdapter);
        }
        public DollarRequestBuilder Dollar { get =>
            new DollarRequestBuilder(PathParameters, RequestAdapter);
        }
        public DollarDeRequestBuilder DollarDe { get =>
            new DollarDeRequestBuilder(PathParameters, RequestAdapter);
        }
        public DollarFrRequestBuilder DollarFr { get =>
            new DollarFrRequestBuilder(PathParameters, RequestAdapter);
        }
        public DproductRequestBuilder Dproduct { get =>
            new DproductRequestBuilder(PathParameters, RequestAdapter);
        }
        public DstDevRequestBuilder DstDev { get =>
            new DstDevRequestBuilder(PathParameters, RequestAdapter);
        }
        public DstDevPRequestBuilder DstDevP { get =>
            new DstDevPRequestBuilder(PathParameters, RequestAdapter);
        }
        public DsumRequestBuilder Dsum { get =>
            new DsumRequestBuilder(PathParameters, RequestAdapter);
        }
        public DurationRequestBuilder Duration { get =>
            new DurationRequestBuilder(PathParameters, RequestAdapter);
        }
        public DvarRequestBuilder Dvar { get =>
            new DvarRequestBuilder(PathParameters, RequestAdapter);
        }
        public DvarPRequestBuilder DvarP { get =>
            new DvarPRequestBuilder(PathParameters, RequestAdapter);
        }
        public Ecma_CeilingRequestBuilder Ecma_Ceiling { get =>
            new Ecma_CeilingRequestBuilder(PathParameters, RequestAdapter);
        }
        public EdateRequestBuilder Edate { get =>
            new EdateRequestBuilder(PathParameters, RequestAdapter);
        }
        public EffectRequestBuilder Effect { get =>
            new EffectRequestBuilder(PathParameters, RequestAdapter);
        }
        public EoMonthRequestBuilder EoMonth { get =>
            new EoMonthRequestBuilder(PathParameters, RequestAdapter);
        }
        public ErfRequestBuilder Erf { get =>
            new ErfRequestBuilder(PathParameters, RequestAdapter);
        }
        public Erf_PreciseRequestBuilder Erf_Precise { get =>
            new Erf_PreciseRequestBuilder(PathParameters, RequestAdapter);
        }
        public ErfCRequestBuilder ErfC { get =>
            new ErfCRequestBuilder(PathParameters, RequestAdapter);
        }
        public ErfC_PreciseRequestBuilder ErfC_Precise { get =>
            new ErfC_PreciseRequestBuilder(PathParameters, RequestAdapter);
        }
        public Error_TypeRequestBuilder Error_Type { get =>
            new Error_TypeRequestBuilder(PathParameters, RequestAdapter);
        }
        public EvenRequestBuilder Even { get =>
            new EvenRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExactRequestBuilder Exact { get =>
            new ExactRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExpRequestBuilder Exp { get =>
            new ExpRequestBuilder(PathParameters, RequestAdapter);
        }
        public Expon_DistRequestBuilder Expon_Dist { get =>
            new Expon_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public F_DistRequestBuilder F_Dist { get =>
            new F_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public F_Dist_RTRequestBuilder F_Dist_RT { get =>
            new F_Dist_RTRequestBuilder(PathParameters, RequestAdapter);
        }
        public F_InvRequestBuilder F_Inv { get =>
            new F_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public F_Inv_RTRequestBuilder F_Inv_RT { get =>
            new F_Inv_RTRequestBuilder(PathParameters, RequestAdapter);
        }
        public FactRequestBuilder Fact { get =>
            new FactRequestBuilder(PathParameters, RequestAdapter);
        }
        public FactDoubleRequestBuilder FactDouble { get =>
            new FactDoubleRequestBuilder(PathParameters, RequestAdapter);
        }
        public FalseRequestBuilder False { get =>
            new FalseRequestBuilder(PathParameters, RequestAdapter);
        }
        public FindRequestBuilder Find { get =>
            new FindRequestBuilder(PathParameters, RequestAdapter);
        }
        public FindBRequestBuilder FindB { get =>
            new FindBRequestBuilder(PathParameters, RequestAdapter);
        }
        public FisherRequestBuilder Fisher { get =>
            new FisherRequestBuilder(PathParameters, RequestAdapter);
        }
        public FisherInvRequestBuilder FisherInv { get =>
            new FisherInvRequestBuilder(PathParameters, RequestAdapter);
        }
        public FixedRequestBuilder Fixed { get =>
            new FixedRequestBuilder(PathParameters, RequestAdapter);
        }
        public Floor_MathRequestBuilder Floor_Math { get =>
            new Floor_MathRequestBuilder(PathParameters, RequestAdapter);
        }
        public Floor_PreciseRequestBuilder Floor_Precise { get =>
            new Floor_PreciseRequestBuilder(PathParameters, RequestAdapter);
        }
        public FvRequestBuilder Fv { get =>
            new FvRequestBuilder(PathParameters, RequestAdapter);
        }
        public FvscheduleRequestBuilder Fvschedule { get =>
            new FvscheduleRequestBuilder(PathParameters, RequestAdapter);
        }
        public GammaRequestBuilder Gamma { get =>
            new GammaRequestBuilder(PathParameters, RequestAdapter);
        }
        public Gamma_DistRequestBuilder Gamma_Dist { get =>
            new Gamma_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public Gamma_InvRequestBuilder Gamma_Inv { get =>
            new Gamma_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public GammaLnRequestBuilder GammaLn { get =>
            new GammaLnRequestBuilder(PathParameters, RequestAdapter);
        }
        public GammaLn_PreciseRequestBuilder GammaLn_Precise { get =>
            new GammaLn_PreciseRequestBuilder(PathParameters, RequestAdapter);
        }
        public GaussRequestBuilder Gauss { get =>
            new GaussRequestBuilder(PathParameters, RequestAdapter);
        }
        public GcdRequestBuilder Gcd { get =>
            new GcdRequestBuilder(PathParameters, RequestAdapter);
        }
        public GeoMeanRequestBuilder GeoMean { get =>
            new GeoMeanRequestBuilder(PathParameters, RequestAdapter);
        }
        public GeStepRequestBuilder GeStep { get =>
            new GeStepRequestBuilder(PathParameters, RequestAdapter);
        }
        public HarMeanRequestBuilder HarMean { get =>
            new HarMeanRequestBuilder(PathParameters, RequestAdapter);
        }
        public Hex2BinRequestBuilder Hex2Bin { get =>
            new Hex2BinRequestBuilder(PathParameters, RequestAdapter);
        }
        public Hex2DecRequestBuilder Hex2Dec { get =>
            new Hex2DecRequestBuilder(PathParameters, RequestAdapter);
        }
        public Hex2OctRequestBuilder Hex2Oct { get =>
            new Hex2OctRequestBuilder(PathParameters, RequestAdapter);
        }
        public HlookupRequestBuilder Hlookup { get =>
            new HlookupRequestBuilder(PathParameters, RequestAdapter);
        }
        public HourRequestBuilder Hour { get =>
            new HourRequestBuilder(PathParameters, RequestAdapter);
        }
        public HyperlinkRequestBuilder Hyperlink { get =>
            new HyperlinkRequestBuilder(PathParameters, RequestAdapter);
        }
        public HypGeom_DistRequestBuilder HypGeom_Dist { get =>
            new HypGeom_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public IfRequestBuilder If { get =>
            new IfRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImAbsRequestBuilder ImAbs { get =>
            new ImAbsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImaginaryRequestBuilder Imaginary { get =>
            new ImaginaryRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImArgumentRequestBuilder ImArgument { get =>
            new ImArgumentRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImConjugateRequestBuilder ImConjugate { get =>
            new ImConjugateRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImCosRequestBuilder ImCos { get =>
            new ImCosRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImCoshRequestBuilder ImCosh { get =>
            new ImCoshRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImCotRequestBuilder ImCot { get =>
            new ImCotRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImCscRequestBuilder ImCsc { get =>
            new ImCscRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImCschRequestBuilder ImCsch { get =>
            new ImCschRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImDivRequestBuilder ImDiv { get =>
            new ImDivRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImExpRequestBuilder ImExp { get =>
            new ImExpRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImLnRequestBuilder ImLn { get =>
            new ImLnRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImLog10RequestBuilder ImLog10 { get =>
            new ImLog10RequestBuilder(PathParameters, RequestAdapter);
        }
        public ImLog2RequestBuilder ImLog2 { get =>
            new ImLog2RequestBuilder(PathParameters, RequestAdapter);
        }
        public ImPowerRequestBuilder ImPower { get =>
            new ImPowerRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImProductRequestBuilder ImProduct { get =>
            new ImProductRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImRealRequestBuilder ImReal { get =>
            new ImRealRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImSecRequestBuilder ImSec { get =>
            new ImSecRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImSechRequestBuilder ImSech { get =>
            new ImSechRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImSinRequestBuilder ImSin { get =>
            new ImSinRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImSinhRequestBuilder ImSinh { get =>
            new ImSinhRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImSqrtRequestBuilder ImSqrt { get =>
            new ImSqrtRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImSubRequestBuilder ImSub { get =>
            new ImSubRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImSumRequestBuilder ImSum { get =>
            new ImSumRequestBuilder(PathParameters, RequestAdapter);
        }
        public ImTanRequestBuilder ImTan { get =>
            new ImTanRequestBuilder(PathParameters, RequestAdapter);
        }
        public IntRequestBuilder Int { get =>
            new IntRequestBuilder(PathParameters, RequestAdapter);
        }
        public IntRateRequestBuilder IntRate { get =>
            new IntRateRequestBuilder(PathParameters, RequestAdapter);
        }
        public IpmtRequestBuilder Ipmt { get =>
            new IpmtRequestBuilder(PathParameters, RequestAdapter);
        }
        public IrrRequestBuilder Irr { get =>
            new IrrRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsErrRequestBuilder IsErr { get =>
            new IsErrRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsErrorRequestBuilder IsError { get =>
            new IsErrorRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsEvenRequestBuilder IsEven { get =>
            new IsEvenRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsFormulaRequestBuilder IsFormula { get =>
            new IsFormulaRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsLogicalRequestBuilder IsLogical { get =>
            new IsLogicalRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsNARequestBuilder IsNA { get =>
            new IsNARequestBuilder(PathParameters, RequestAdapter);
        }
        public IsNonTextRequestBuilder IsNonText { get =>
            new IsNonTextRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsNumberRequestBuilder IsNumber { get =>
            new IsNumberRequestBuilder(PathParameters, RequestAdapter);
        }
        public Iso_CeilingRequestBuilder Iso_Ceiling { get =>
            new Iso_CeilingRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsOddRequestBuilder IsOdd { get =>
            new IsOddRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsoWeekNumRequestBuilder IsoWeekNum { get =>
            new IsoWeekNumRequestBuilder(PathParameters, RequestAdapter);
        }
        public IspmtRequestBuilder Ispmt { get =>
            new IspmtRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsrefRequestBuilder Isref { get =>
            new IsrefRequestBuilder(PathParameters, RequestAdapter);
        }
        public IsTextRequestBuilder IsText { get =>
            new IsTextRequestBuilder(PathParameters, RequestAdapter);
        }
        public KurtRequestBuilder Kurt { get =>
            new KurtRequestBuilder(PathParameters, RequestAdapter);
        }
        public LargeRequestBuilder Large { get =>
            new LargeRequestBuilder(PathParameters, RequestAdapter);
        }
        public LcmRequestBuilder Lcm { get =>
            new LcmRequestBuilder(PathParameters, RequestAdapter);
        }
        public LeftRequestBuilder Left { get =>
            new LeftRequestBuilder(PathParameters, RequestAdapter);
        }
        public LeftbRequestBuilder Leftb { get =>
            new LeftbRequestBuilder(PathParameters, RequestAdapter);
        }
        public LenRequestBuilder Len { get =>
            new LenRequestBuilder(PathParameters, RequestAdapter);
        }
        public LenbRequestBuilder Lenb { get =>
            new LenbRequestBuilder(PathParameters, RequestAdapter);
        }
        public LnRequestBuilder Ln { get =>
            new LnRequestBuilder(PathParameters, RequestAdapter);
        }
        public LogRequestBuilder Log { get =>
            new LogRequestBuilder(PathParameters, RequestAdapter);
        }
        public Log10RequestBuilder Log10 { get =>
            new Log10RequestBuilder(PathParameters, RequestAdapter);
        }
        public LogNorm_DistRequestBuilder LogNorm_Dist { get =>
            new LogNorm_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public LogNorm_InvRequestBuilder LogNorm_Inv { get =>
            new LogNorm_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public LookupRequestBuilder Lookup { get =>
            new LookupRequestBuilder(PathParameters, RequestAdapter);
        }
        public LowerRequestBuilder Lower { get =>
            new LowerRequestBuilder(PathParameters, RequestAdapter);
        }
        public MatchRequestBuilder Match { get =>
            new MatchRequestBuilder(PathParameters, RequestAdapter);
        }
        public MaxRequestBuilder Max { get =>
            new MaxRequestBuilder(PathParameters, RequestAdapter);
        }
        public MaxARequestBuilder MaxA { get =>
            new MaxARequestBuilder(PathParameters, RequestAdapter);
        }
        public MdurationRequestBuilder Mduration { get =>
            new MdurationRequestBuilder(PathParameters, RequestAdapter);
        }
        public MedianRequestBuilder Median { get =>
            new MedianRequestBuilder(PathParameters, RequestAdapter);
        }
        public MidRequestBuilder Mid { get =>
            new MidRequestBuilder(PathParameters, RequestAdapter);
        }
        public MidbRequestBuilder Midb { get =>
            new MidbRequestBuilder(PathParameters, RequestAdapter);
        }
        public MinRequestBuilder Min { get =>
            new MinRequestBuilder(PathParameters, RequestAdapter);
        }
        public MinARequestBuilder MinA { get =>
            new MinARequestBuilder(PathParameters, RequestAdapter);
        }
        public MinuteRequestBuilder Minute { get =>
            new MinuteRequestBuilder(PathParameters, RequestAdapter);
        }
        public MirrRequestBuilder Mirr { get =>
            new MirrRequestBuilder(PathParameters, RequestAdapter);
        }
        public ModRequestBuilder Mod { get =>
            new ModRequestBuilder(PathParameters, RequestAdapter);
        }
        public MonthRequestBuilder Month { get =>
            new MonthRequestBuilder(PathParameters, RequestAdapter);
        }
        public MroundRequestBuilder Mround { get =>
            new MroundRequestBuilder(PathParameters, RequestAdapter);
        }
        public MultiNomialRequestBuilder MultiNomial { get =>
            new MultiNomialRequestBuilder(PathParameters, RequestAdapter);
        }
        public NRequestBuilder N { get =>
            new NRequestBuilder(PathParameters, RequestAdapter);
        }
        public NaRequestBuilder Na { get =>
            new NaRequestBuilder(PathParameters, RequestAdapter);
        }
        public NegBinom_DistRequestBuilder NegBinom_Dist { get =>
            new NegBinom_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public NetworkDaysRequestBuilder NetworkDays { get =>
            new NetworkDaysRequestBuilder(PathParameters, RequestAdapter);
        }
        public NetworkDays_IntlRequestBuilder NetworkDays_Intl { get =>
            new NetworkDays_IntlRequestBuilder(PathParameters, RequestAdapter);
        }
        public NominalRequestBuilder Nominal { get =>
            new NominalRequestBuilder(PathParameters, RequestAdapter);
        }
        public Norm_DistRequestBuilder Norm_Dist { get =>
            new Norm_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public Norm_InvRequestBuilder Norm_Inv { get =>
            new Norm_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public Norm_S_DistRequestBuilder Norm_S_Dist { get =>
            new Norm_S_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public Norm_S_InvRequestBuilder Norm_S_Inv { get =>
            new Norm_S_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public NotRequestBuilder Not { get =>
            new NotRequestBuilder(PathParameters, RequestAdapter);
        }
        public NowRequestBuilder Now { get =>
            new NowRequestBuilder(PathParameters, RequestAdapter);
        }
        public NperRequestBuilder Nper { get =>
            new NperRequestBuilder(PathParameters, RequestAdapter);
        }
        public NpvRequestBuilder Npv { get =>
            new NpvRequestBuilder(PathParameters, RequestAdapter);
        }
        public NumberValueRequestBuilder NumberValue { get =>
            new NumberValueRequestBuilder(PathParameters, RequestAdapter);
        }
        public Oct2BinRequestBuilder Oct2Bin { get =>
            new Oct2BinRequestBuilder(PathParameters, RequestAdapter);
        }
        public Oct2DecRequestBuilder Oct2Dec { get =>
            new Oct2DecRequestBuilder(PathParameters, RequestAdapter);
        }
        public Oct2HexRequestBuilder Oct2Hex { get =>
            new Oct2HexRequestBuilder(PathParameters, RequestAdapter);
        }
        public OddRequestBuilder Odd { get =>
            new OddRequestBuilder(PathParameters, RequestAdapter);
        }
        public OddFPriceRequestBuilder OddFPrice { get =>
            new OddFPriceRequestBuilder(PathParameters, RequestAdapter);
        }
        public OddFYieldRequestBuilder OddFYield { get =>
            new OddFYieldRequestBuilder(PathParameters, RequestAdapter);
        }
        public OddLPriceRequestBuilder OddLPrice { get =>
            new OddLPriceRequestBuilder(PathParameters, RequestAdapter);
        }
        public OddLYieldRequestBuilder OddLYield { get =>
            new OddLYieldRequestBuilder(PathParameters, RequestAdapter);
        }
        public OrRequestBuilder Or { get =>
            new OrRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PdurationRequestBuilder Pduration { get =>
            new PdurationRequestBuilder(PathParameters, RequestAdapter);
        }
        public Percentile_ExcRequestBuilder Percentile_Exc { get =>
            new Percentile_ExcRequestBuilder(PathParameters, RequestAdapter);
        }
        public Percentile_IncRequestBuilder Percentile_Inc { get =>
            new Percentile_IncRequestBuilder(PathParameters, RequestAdapter);
        }
        public PercentRank_ExcRequestBuilder PercentRank_Exc { get =>
            new PercentRank_ExcRequestBuilder(PathParameters, RequestAdapter);
        }
        public PercentRank_IncRequestBuilder PercentRank_Inc { get =>
            new PercentRank_IncRequestBuilder(PathParameters, RequestAdapter);
        }
        public PermutRequestBuilder Permut { get =>
            new PermutRequestBuilder(PathParameters, RequestAdapter);
        }
        public PermutationaRequestBuilder Permutationa { get =>
            new PermutationaRequestBuilder(PathParameters, RequestAdapter);
        }
        public PhiRequestBuilder Phi { get =>
            new PhiRequestBuilder(PathParameters, RequestAdapter);
        }
        public PiRequestBuilder Pi { get =>
            new PiRequestBuilder(PathParameters, RequestAdapter);
        }
        public PmtRequestBuilder Pmt { get =>
            new PmtRequestBuilder(PathParameters, RequestAdapter);
        }
        public Poisson_DistRequestBuilder Poisson_Dist { get =>
            new Poisson_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public PowerRequestBuilder Power { get =>
            new PowerRequestBuilder(PathParameters, RequestAdapter);
        }
        public PpmtRequestBuilder Ppmt { get =>
            new PpmtRequestBuilder(PathParameters, RequestAdapter);
        }
        public PriceRequestBuilder Price { get =>
            new PriceRequestBuilder(PathParameters, RequestAdapter);
        }
        public PriceDiscRequestBuilder PriceDisc { get =>
            new PriceDiscRequestBuilder(PathParameters, RequestAdapter);
        }
        public PriceMatRequestBuilder PriceMat { get =>
            new PriceMatRequestBuilder(PathParameters, RequestAdapter);
        }
        public ProductRequestBuilder Product { get =>
            new ProductRequestBuilder(PathParameters, RequestAdapter);
        }
        public ProperRequestBuilder Proper { get =>
            new ProperRequestBuilder(PathParameters, RequestAdapter);
        }
        public PvRequestBuilder Pv { get =>
            new PvRequestBuilder(PathParameters, RequestAdapter);
        }
        public Quartile_ExcRequestBuilder Quartile_Exc { get =>
            new Quartile_ExcRequestBuilder(PathParameters, RequestAdapter);
        }
        public Quartile_IncRequestBuilder Quartile_Inc { get =>
            new Quartile_IncRequestBuilder(PathParameters, RequestAdapter);
        }
        public QuotientRequestBuilder Quotient { get =>
            new QuotientRequestBuilder(PathParameters, RequestAdapter);
        }
        public RadiansRequestBuilder Radians { get =>
            new RadiansRequestBuilder(PathParameters, RequestAdapter);
        }
        public RandRequestBuilder Rand { get =>
            new RandRequestBuilder(PathParameters, RequestAdapter);
        }
        public RandBetweenRequestBuilder RandBetween { get =>
            new RandBetweenRequestBuilder(PathParameters, RequestAdapter);
        }
        public Rank_AvgRequestBuilder Rank_Avg { get =>
            new Rank_AvgRequestBuilder(PathParameters, RequestAdapter);
        }
        public Rank_EqRequestBuilder Rank_Eq { get =>
            new Rank_EqRequestBuilder(PathParameters, RequestAdapter);
        }
        public RateRequestBuilder Rate { get =>
            new RateRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReceivedRequestBuilder Received { get =>
            new ReceivedRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReplaceRequestBuilder Replace { get =>
            new ReplaceRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReplaceBRequestBuilder ReplaceB { get =>
            new ReplaceBRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReptRequestBuilder Rept { get =>
            new ReptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RightRequestBuilder Right { get =>
            new RightRequestBuilder(PathParameters, RequestAdapter);
        }
        public RightbRequestBuilder Rightb { get =>
            new RightbRequestBuilder(PathParameters, RequestAdapter);
        }
        public RomanRequestBuilder Roman { get =>
            new RomanRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoundRequestBuilder Round { get =>
            new RoundRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoundDownRequestBuilder RoundDown { get =>
            new RoundDownRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoundUpRequestBuilder RoundUp { get =>
            new RoundUpRequestBuilder(PathParameters, RequestAdapter);
        }
        public RowsRequestBuilder Rows { get =>
            new RowsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RriRequestBuilder Rri { get =>
            new RriRequestBuilder(PathParameters, RequestAdapter);
        }
        public SecRequestBuilder Sec { get =>
            new SecRequestBuilder(PathParameters, RequestAdapter);
        }
        public SechRequestBuilder Sech { get =>
            new SechRequestBuilder(PathParameters, RequestAdapter);
        }
        public SecondRequestBuilder Second { get =>
            new SecondRequestBuilder(PathParameters, RequestAdapter);
        }
        public SeriesSumRequestBuilder SeriesSum { get =>
            new SeriesSumRequestBuilder(PathParameters, RequestAdapter);
        }
        public SheetRequestBuilder Sheet { get =>
            new SheetRequestBuilder(PathParameters, RequestAdapter);
        }
        public SheetsRequestBuilder Sheets { get =>
            new SheetsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SignRequestBuilder Sign { get =>
            new SignRequestBuilder(PathParameters, RequestAdapter);
        }
        public SinRequestBuilder Sin { get =>
            new SinRequestBuilder(PathParameters, RequestAdapter);
        }
        public SinhRequestBuilder Sinh { get =>
            new SinhRequestBuilder(PathParameters, RequestAdapter);
        }
        public SkewRequestBuilder Skew { get =>
            new SkewRequestBuilder(PathParameters, RequestAdapter);
        }
        public Skew_pRequestBuilder Skew_p { get =>
            new Skew_pRequestBuilder(PathParameters, RequestAdapter);
        }
        public SlnRequestBuilder Sln { get =>
            new SlnRequestBuilder(PathParameters, RequestAdapter);
        }
        public SmallRequestBuilder Small { get =>
            new SmallRequestBuilder(PathParameters, RequestAdapter);
        }
        public SqrtRequestBuilder Sqrt { get =>
            new SqrtRequestBuilder(PathParameters, RequestAdapter);
        }
        public SqrtPiRequestBuilder SqrtPi { get =>
            new SqrtPiRequestBuilder(PathParameters, RequestAdapter);
        }
        public StandardizeRequestBuilder Standardize { get =>
            new StandardizeRequestBuilder(PathParameters, RequestAdapter);
        }
        public StDev_PRequestBuilder StDev_P { get =>
            new StDev_PRequestBuilder(PathParameters, RequestAdapter);
        }
        public StDev_SRequestBuilder StDev_S { get =>
            new StDev_SRequestBuilder(PathParameters, RequestAdapter);
        }
        public StDevARequestBuilder StDevA { get =>
            new StDevARequestBuilder(PathParameters, RequestAdapter);
        }
        public StDevPARequestBuilder StDevPA { get =>
            new StDevPARequestBuilder(PathParameters, RequestAdapter);
        }
        public SubstituteRequestBuilder Substitute { get =>
            new SubstituteRequestBuilder(PathParameters, RequestAdapter);
        }
        public SubtotalRequestBuilder Subtotal { get =>
            new SubtotalRequestBuilder(PathParameters, RequestAdapter);
        }
        public SumRequestBuilder Sum { get =>
            new SumRequestBuilder(PathParameters, RequestAdapter);
        }
        public SumIfRequestBuilder SumIf { get =>
            new SumIfRequestBuilder(PathParameters, RequestAdapter);
        }
        public SumIfsRequestBuilder SumIfs { get =>
            new SumIfsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SumSqRequestBuilder SumSq { get =>
            new SumSqRequestBuilder(PathParameters, RequestAdapter);
        }
        public SydRequestBuilder Syd { get =>
            new SydRequestBuilder(PathParameters, RequestAdapter);
        }
        public TRequestBuilder T { get =>
            new TRequestBuilder(PathParameters, RequestAdapter);
        }
        public T_DistRequestBuilder T_Dist { get =>
            new T_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public T_Dist_2TRequestBuilder T_Dist_2T { get =>
            new T_Dist_2TRequestBuilder(PathParameters, RequestAdapter);
        }
        public T_Dist_RTRequestBuilder T_Dist_RT { get =>
            new T_Dist_RTRequestBuilder(PathParameters, RequestAdapter);
        }
        public T_InvRequestBuilder T_Inv { get =>
            new T_InvRequestBuilder(PathParameters, RequestAdapter);
        }
        public T_Inv_2TRequestBuilder T_Inv_2T { get =>
            new T_Inv_2TRequestBuilder(PathParameters, RequestAdapter);
        }
        public TanRequestBuilder Tan { get =>
            new TanRequestBuilder(PathParameters, RequestAdapter);
        }
        public TanhRequestBuilder Tanh { get =>
            new TanhRequestBuilder(PathParameters, RequestAdapter);
        }
        public TbillEqRequestBuilder TbillEq { get =>
            new TbillEqRequestBuilder(PathParameters, RequestAdapter);
        }
        public TbillPriceRequestBuilder TbillPrice { get =>
            new TbillPriceRequestBuilder(PathParameters, RequestAdapter);
        }
        public TbillYieldRequestBuilder TbillYield { get =>
            new TbillYieldRequestBuilder(PathParameters, RequestAdapter);
        }
        public TextRequestBuilder Text { get =>
            new TextRequestBuilder(PathParameters, RequestAdapter);
        }
        public TimeRequestBuilder Time { get =>
            new TimeRequestBuilder(PathParameters, RequestAdapter);
        }
        public TimevalueRequestBuilder Timevalue { get =>
            new TimevalueRequestBuilder(PathParameters, RequestAdapter);
        }
        public TodayRequestBuilder Today { get =>
            new TodayRequestBuilder(PathParameters, RequestAdapter);
        }
        public TrimRequestBuilder Trim { get =>
            new TrimRequestBuilder(PathParameters, RequestAdapter);
        }
        public TrimMeanRequestBuilder TrimMean { get =>
            new TrimMeanRequestBuilder(PathParameters, RequestAdapter);
        }
        public TrueRequestBuilder True { get =>
            new TrueRequestBuilder(PathParameters, RequestAdapter);
        }
        public TruncRequestBuilder Trunc { get =>
            new TruncRequestBuilder(PathParameters, RequestAdapter);
        }
        public TypeRequestBuilder Type { get =>
            new TypeRequestBuilder(PathParameters, RequestAdapter);
        }
        public UnicharRequestBuilder Unichar { get =>
            new UnicharRequestBuilder(PathParameters, RequestAdapter);
        }
        public UnicodeRequestBuilder Unicode { get =>
            new UnicodeRequestBuilder(PathParameters, RequestAdapter);
        }
        public UpperRequestBuilder Upper { get =>
            new UpperRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UsdollarRequestBuilder Usdollar { get =>
            new UsdollarRequestBuilder(PathParameters, RequestAdapter);
        }
        public ValueRequestBuilder Value { get =>
            new ValueRequestBuilder(PathParameters, RequestAdapter);
        }
        public Var_PRequestBuilder Var_P { get =>
            new Var_PRequestBuilder(PathParameters, RequestAdapter);
        }
        public Var_SRequestBuilder Var_S { get =>
            new Var_SRequestBuilder(PathParameters, RequestAdapter);
        }
        public VarARequestBuilder VarA { get =>
            new VarARequestBuilder(PathParameters, RequestAdapter);
        }
        public VarPARequestBuilder VarPA { get =>
            new VarPARequestBuilder(PathParameters, RequestAdapter);
        }
        public VdbRequestBuilder Vdb { get =>
            new VdbRequestBuilder(PathParameters, RequestAdapter);
        }
        public VlookupRequestBuilder Vlookup { get =>
            new VlookupRequestBuilder(PathParameters, RequestAdapter);
        }
        public WeekdayRequestBuilder Weekday { get =>
            new WeekdayRequestBuilder(PathParameters, RequestAdapter);
        }
        public WeekNumRequestBuilder WeekNum { get =>
            new WeekNumRequestBuilder(PathParameters, RequestAdapter);
        }
        public Weibull_DistRequestBuilder Weibull_Dist { get =>
            new Weibull_DistRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkDayRequestBuilder WorkDay { get =>
            new WorkDayRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkDay_IntlRequestBuilder WorkDay_Intl { get =>
            new WorkDay_IntlRequestBuilder(PathParameters, RequestAdapter);
        }
        public XirrRequestBuilder Xirr { get =>
            new XirrRequestBuilder(PathParameters, RequestAdapter);
        }
        public XnpvRequestBuilder Xnpv { get =>
            new XnpvRequestBuilder(PathParameters, RequestAdapter);
        }
        public XorRequestBuilder Xor { get =>
            new XorRequestBuilder(PathParameters, RequestAdapter);
        }
        public YearRequestBuilder Year { get =>
            new YearRequestBuilder(PathParameters, RequestAdapter);
        }
        public YearFracRequestBuilder YearFrac { get =>
            new YearFracRequestBuilder(PathParameters, RequestAdapter);
        }
        public YieldRequestBuilder Yield { get =>
            new YieldRequestBuilder(PathParameters, RequestAdapter);
        }
        public YieldDiscRequestBuilder YieldDisc { get =>
            new YieldDiscRequestBuilder(PathParameters, RequestAdapter);
        }
        public YieldMatRequestBuilder YieldMat { get =>
            new YieldMatRequestBuilder(PathParameters, RequestAdapter);
        }
        public Z_TestRequestBuilder Z_Test { get =>
            new Z_TestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new FunctionsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FunctionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/functions{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new FunctionsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FunctionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/workbooks/{driveItem_id}/workbook/functions{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property functions for workbooks
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get functions from workbooks
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property functions in workbooks
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(WorkbookFunctions body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property functions for workbooks
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Get functions from workbooks
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<WorkbookFunctions> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<WorkbookFunctions>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property functions in workbooks
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(WorkbookFunctions body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>Get functions from workbooks</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}