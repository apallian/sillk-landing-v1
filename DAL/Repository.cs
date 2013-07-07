using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Logging;

namespace DAL
{
    public static class Repository
    {
        private static LightSpeedContext<SilkRouteUnitOfWork> _context;
        private static PerRequestUnitOfWorkScope<SilkRouteUnitOfWork> _uowScope;
        public static LightSpeedContext<SilkRouteUnitOfWork> Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new LightSpeedContext<SilkRouteUnitOfWork>();
                    _context.CascadeDeletes = true;
                    _context.Logger = new TraceLogger();
                    _context.ConnectionString = LightSpeedContext.Default.ConnectionString;
                    //_context.ConnectionString = "server=implement/sqlserver2005;database=ivault307_CWB;Integrated Security=SSPI";
                    _context.PluralizeTableNames = LightSpeedContext.Default.PluralizeTableNames;
                    _context.IdentityMethod = IdentityMethod.IdentityColumn;
                }
                return _context;
            }
        }

        public static void DisposeUoW()
        {
            if (_uowScope != null)
            {
                _uowScope.Current.Dispose();
            }
        }

        public static SilkRouteUnitOfWork Uow
        {
            get
            {
                if (_uowScope == null)
                    _uowScope = new PerRequestUnitOfWorkScope<SilkRouteUnitOfWork>(Context);

                return _uowScope.Current;
            }
        }

    }
}
